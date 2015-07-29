using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter5Task
{
    public partial class Form1 : Form
    {
        private bool isRunning = true;
        private static readonly Queue<string> queue = new Queue<string>();
        private static readonly SyncEvents syncEvents = new SyncEvents();

        private static readonly Producer producer = new Producer(queue, syncEvents);
        private static readonly SecondProducer secondProducer = new SecondProducer(queue, syncEvents);

        private readonly Thread producerThread = new Thread(producer.ThreadRun);
        private readonly Thread secondProducerThread = new Thread(secondProducer.ThreadRun);


        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Run on Form event OnShown to start threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_btn_Click(object sender, EventArgs e)
        {
            producerThread.IsBackground = true;
            secondProducerThread.IsBackground = true;

            producerThread.Start();
            secondProducerThread.Start();
        }
        /// <summary>
        /// Start for generation exceptions and show them on textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_btn_Click(object sender, EventArgs e)
        {
            isRunning = true;
            textBox1.Text += @"Let`s start throw exceptions..." + Environment.NewLine;
            while (isRunning)
            {
                textBox1.Text += ShowQueueContents(queue);
                if (queue.Count > 0)
                {
                   queue.Dequeue(); 
                }
                Application.DoEvents();
            }
            
        }
        
        /// <summary>
        /// Stop generate exceptions(sometimes works with second mouse click!)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_generate_btn_Click(object sender, EventArgs e)
        {
            isRunning = false;
            textBox1.Text += @"Stop throw exceptions..." + Environment.NewLine;
        }

        /// <summary>
        /// Set event for terminate threads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exit_btn_Click(object sender, EventArgs e)
        {
            isRunning = false;

            textBox1.Text += @"Terminate threads..." + Environment.NewLine;
            syncEvents.ExitThreadEvent.Set();

            producerThread.Join();
            secondProducerThread.Join();

            Application.Exit();
        }

        /// <summary>
        /// Show formatted strings in queue
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        private static string ShowQueueContents(Queue<string> collection)
        {
            var _summary = String.Empty;

            lock (((ICollection)collection).SyncRoot)
            {
                foreach (var item in collection)
                {
                    _summary += String.Format("{0}", item) + Environment.NewLine;
                }
            }
            return _summary;      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();
        }
    }
}
