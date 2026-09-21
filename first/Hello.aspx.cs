using System;

namespace first
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
        }

        protected void PrintBTN_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(num1.Text);
            int number2 = Convert.ToInt32(num2.Text);
            Label3.Visible = true;
            Label3.Text = "<br>Number 1: " + number1 +
              "<br/>Number 2: " + number2 +
              "<br/>Addition: " + (number1 + number2) +
              "<br/>Subtraction: " + (number1 - number2) +
              "<br/>Multiplication: " + (number1 * number2) +
              "<br/>Division: " + (number1 / number2);

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}