using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;
using Calendar = System.Web.UI.WebControls.Calendar;

namespace WebPart3Task
{
    public partial class Default : Page
    {
        DropDownList country = new DropDownList() { ID = "country" };
        DropDownList city = new DropDownList() { ID = "city" };
        TextBox birthDateBox = new TextBox() { ID = "birthDateBox" };
        Calendar calendar = new Calendar() { ID = "myCalendar" };

        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox nickNameBox = new TextBox() { ID = "nickNameBox" };
            TextBox nameBox = new TextBox() { ID = "nameBox" };
            TextBox sirNameBox = new TextBox() { ID = "sirNameBox" };
            TextBox emailBox = new TextBox { ID = "emailBox" };
            Label registrationFormLabel = new Label { Text = "Registration form:" };
            Label nicknameLabel = new Label { Text = "Nick Name:" };
            Label nameLabel = new Label { Text = "First name:" };
            Label sirnameLabel = new Label { Text = "Last name:" };
            Label dateOfBirthLabel = new Label { Text = "Date of birth:" };
            Label emailLabel = new Label { Text = "E-mail:" };
            Label countryLabel = new Label { Text = "Country:" };
            Label cityLabel = new Label { Text = "City:" };
            Label validationSummaryLabel = new Label { Text = "Validation Summary:" };

            RegularExpressionValidator emailvalidator = new RegularExpressionValidator() { ValidationExpression = @"[a-zA-Z_0-9.-]+\@[a-zA-Z_0-9.-]+\.\w+", ControlToValidate = "emailBox", ForeColor = Color.Crimson, ErrorMessage = "Enter correct email please..." };
            RequiredFieldValidator requiredEmail = new RequiredFieldValidator() { ControlToValidate = "emailBox", ForeColor = Color.Crimson, ErrorMessage = "Enter e-mail please..." };
            RequiredFieldValidator requiredCountry = new RequiredFieldValidator() { ControlToValidate = "country", ForeColor = Color.Crimson, ErrorMessage = "Select country please..." };
            RequiredFieldValidator requiredCity = new RequiredFieldValidator() { ControlToValidate = "city", ForeColor = Color.Crimson, ErrorMessage = "Select city please..." };
            RequiredFieldValidator requiredNickname = new RequiredFieldValidator() { ControlToValidate = "nickNameBox", ForeColor = Color.Crimson, ErrorMessage = "Enter nickname please..." };
            RequiredFieldValidator requiredName = new RequiredFieldValidator() { ControlToValidate = "nameBox", ForeColor = Color.Crimson, ErrorMessage = "Enter first name please..." };
            RequiredFieldValidator requiredSirname = new RequiredFieldValidator() { ControlToValidate = "sirNameBox", ForeColor = Color.Crimson, ErrorMessage = "Enter last name please..." };
            RequiredFieldValidator requiredDate = new RequiredFieldValidator() { ControlToValidate = "birthDateBox", ForeColor = Color.Crimson, ErrorMessage = "Select the date please..." };
            CompareValidator nameToNick = new CompareValidator() { ControlToValidate = "nameBox", ControlToCompare = "nickNameBox", Operator = ValidationCompareOperator.NotEqual, ForeColor = Color.Crimson, ErrorMessage = "Shouldn`t be equal to nickname!" };
            CompareValidator sirnameToName = new CompareValidator() { ControlToValidate = "sirNameBox", ControlToCompare = "nameBox", Operator = ValidationCompareOperator.NotEqual, ForeColor = Color.Crimson, ErrorMessage = "Shouldn`t be equal to name!" };
            RangeValidator dateValidator = new RangeValidator() { ControlToValidate = "birthDateBox",MinimumValue = new DateTime(1960,12,1).ToShortDateString(),MaximumValue = DateTime.Now.ToShortDateString(),Type=ValidationDataType.Date, ForeColor = Color.Crimson, ErrorMessage = "Date of birth should be between 12/1/1960 and " + DateTime.Now.ToShortDateString() };
            CompareValidator notDefaultCountry = new CompareValidator() { ControlToValidate = "country", ValueToCompare = "Choose from there", Operator = ValidationCompareOperator.NotEqual, ForeColor = Color.Crimson, ErrorMessage = "Please select country!" };
            CompareValidator notDefaultCity = new CompareValidator() { ControlToValidate = "city", ValueToCompare = "Choose country first", Operator = ValidationCompareOperator.NotEqual, ForeColor = Color.Crimson, ErrorMessage = "Please, select city!" };
            
            ValidationSummary summary = new ValidationSummary() { ForeColor = Color.Crimson };

            Button submitButton = new Button();

            registrationFormLabel.Style["Position"] = "Absolute";
            registrationFormLabel.Style["Top"] = "25px";
            registrationFormLabel.Style["Left"] = "100px";
            registrationFormLabel.Font.Size = 24;
            registrationFormLabel.Font.Bold = true;

            nicknameLabel.Style["Position"] = "Absolute";
            nicknameLabel.Style["Top"] = "90px";
            nicknameLabel.Style["Left"] = "100px";
            nickNameBox.Style["Position"] = "Absolute";
            nickNameBox.Style["Top"] = "90px";
            nickNameBox.Style["Left"] = "250px";
            requiredNickname.Style["Position"] = "Absolute";
            requiredNickname.Style["Top"] = "90px";
            requiredNickname.Style["Left"] = "550px";

            nameLabel.Style["Position"] = "Absolute";
            nameLabel.Style["Top"] = "125px";
            nameLabel.Style["Left"] = "100px";
            nameBox.Style["Position"] = "Absolute";
            nameBox.Style["Top"] = "125px";
            nameBox.Style["Left"] = "250px";
            requiredName.Style["Position"] = "Absolute";
            requiredName.Style["Top"] = "125px";
            requiredName.Style["Left"] = "550px";
            nameToNick.Style["Position"] = "Absolute";
            nameToNick.Style["Top"] = "125px";
            nameToNick.Style["Left"] = "550px";

            sirnameLabel.Style["Position"] = "Absolute";
            sirnameLabel.Style["Top"] = "160px";
            sirnameLabel.Style["Left"] = "100px";
            sirNameBox.Style["Position"] = "Absolute";
            sirNameBox.Style["Top"] = "160px";
            sirNameBox.Style["Left"] = "250px";
            requiredSirname.Style["Position"] = "Absolute";
            requiredSirname.Style["Top"] = "160px";
            requiredSirname.Style["Left"] = "550px";
            sirnameToName.Style["Position"] = "Absolute";
            sirnameToName.Style["Top"] = "160px";
            sirnameToName.Style["Left"] = "550px";

            dateOfBirthLabel.Style["Position"] = "Absolute";
            dateOfBirthLabel.Style["Top"] = "195px";
            dateOfBirthLabel.Style["Left"] = "100px";
            birthDateBox.Style["Position"] = "Absolute";
            birthDateBox.Style["Top"] = "195px";
            birthDateBox.Style["Left"] = "250px";
            calendar.Style["Position"] = "Absolute";
            calendar.Style["Top"] = "230px";
            calendar.Style["Left"] = "250px";
            calendar.SelectionChanged += Calendar1_SelectionChanged; 
            dateValidator.Style["Position"] = "Absolute";
            dateValidator.Style["Top"] = "195px";
            dateValidator.Style["Left"] = "550px";
            requiredDate.Style["Position"] = "Absolute";
            requiredDate.Style["Top"] = "195px";
            requiredDate.Style["Left"] = "550px";

            emailLabel.Style["Position"] = "Absolute";
            emailLabel.Style["Top"] = "425px";
            emailLabel.Style["Left"] = "100px";
            emailBox.Style["Position"] = "Absolute";
            emailBox.Style["Top"] = "425px";
            emailBox.Style["Left"] = "250px";
            emailvalidator.Style["Position"] = "Absolute";
            emailvalidator.Style["Top"] = "425px";
            emailvalidator.Style["Left"] = "550px";
            requiredEmail.Style["Position"] = "Absolute";
            requiredEmail.Style["Top"] = "425px";
            requiredEmail.Style["Left"] = "550px";

            countryLabel.Style["Position"] = "Absolute";
            countryLabel.Style["Top"] = "460px";
            countryLabel.Style["Left"] = "100px";
            country.Style["Position"] = "Absolute";
            country.Style["Top"] = "460px";
            country.Style["Left"] = "250px";
            requiredCountry.Style["Position"] = "Absolute";
            requiredCountry.Style["Top"] = "460px";
            requiredCountry.Style["Left"] = "550px";
            notDefaultCountry.Style["Position"] = "Absolute";
            notDefaultCountry.Style["Top"] = "460px";
            notDefaultCountry.Style["Left"] = "550px";
            country.Items.Add(new ListItem("Choose from there", "Choose from there"));
            country.Items.Add(new ListItem("Ukraine", "Ukraine"));
            country.Items.Add(new ListItem("Chech Republic", "Chech Republic"));
            country.SelectedIndexChanged += Country_ChangeSelection;
            country.AutoPostBack = true;

            cityLabel.Style["Position"] = "Absolute";
            cityLabel.Style["Top"] = "495px";
            cityLabel.Style["Left"] = "100px";
            city.Style["Position"] = "Absolute";
            city.Style["Top"] = "495px";
            city.Style["Left"] = "250px";
            requiredCity.Style["Position"] = "Absolute";
            requiredCity.Style["Top"] = "495px";
            requiredCity.Style["Left"] = "550px";
            city.Items.Add(new ListItem("Choose country first", "Choose country first"));
            notDefaultCity.Style["Position"] = "Absolute";
            notDefaultCity.Style["Top"] = "495px";
            notDefaultCity.Style["Left"] = "550px";

            validationSummaryLabel.Style["Position"] = "Absolute";
            validationSummaryLabel.Style["Top"] = "530px";
            validationSummaryLabel.Style["Left"] = "100px";
            summary.Style["Position"] = "Absolute";
            summary.Style["Top"] = "530px";
            summary.Style["Left"] = "250px";

            submitButton.Style["Position"] = "Absolute";
            submitButton.Style["Top"] = "600px";
            submitButton.Style["Left"] = "100px";
            submitButton.Text = "Submit";
            submitButton.Click += submitButton_Click;


            form1.Controls.Add(nickNameBox);
            form1.Controls.Add(nameBox);
            form1.Controls.Add(sirNameBox);
            form1.Controls.Add(birthDateBox);
            form1.Controls.Add(calendar);
            form1.Controls.Add(emailBox);
            form1.Controls.Add(country);
            form1.Controls.Add(city);
            form1.Controls.Add(submitButton);
            form1.Controls.Add(summary);
            form1.Controls.Add(registrationFormLabel);
            form1.Controls.Add(nicknameLabel);
            form1.Controls.Add(nameLabel);
            form1.Controls.Add(sirnameLabel);
            form1.Controls.Add(dateOfBirthLabel);
            form1.Controls.Add(emailLabel);
            form1.Controls.Add(countryLabel);
            form1.Controls.Add(cityLabel);
            form1.Controls.Add(validationSummaryLabel);
            form1.Controls.Add(emailvalidator);
            form1.Controls.Add(requiredEmail);
            form1.Controls.Add(requiredNickname);
            form1.Controls.Add(requiredName);
            form1.Controls.Add(requiredSirname);
            form1.Controls.Add(nameToNick);
            form1.Controls.Add(sirnameToName);
            form1.Controls.Add(dateValidator);
            form1.Controls.Add(requiredDate);
            form1.Controls.Add(requiredCountry);
            form1.Controls.Add(requiredCity);
            form1.Controls.Add(notDefaultCountry);
            form1.Controls.Add(notDefaultCity);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid) return;
            Response.Write("Your information has been delivered to server!");
            Response.End();
        }
        private void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            birthDateBox.Text = Convert.ToDateTime(calendar.SelectedDate, CultureInfo.GetCultureInfo("en-US")).ToString("MM/dd/yyyy");
        }

        private void Country_ChangeSelection(object sender, EventArgs e)
        {
            switch (country.SelectedItem.Value)
            {
                case "Ukraine": city.Items.Clear(); city.Items.Add(new ListItem("Kharkov", "Kharkov")); city.Items.Add(new ListItem("Kiev", "Kiev"));
                    break;
                case"Chech Republic":city.Items.Clear(); city.Items.Add(new ListItem("Praga", "Praga")); city.Items.Add(new ListItem("Plsen", "Plsen"));
                    break;
                default: city.Items.Clear(); city.Items.Add(new ListItem("Choose country first", "Choose country first"));
                    break;
            }
        }
    }
}