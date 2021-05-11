using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        //ArrayList listOfvalues = new ArrayList(); // store values for processing
        //ArrayList listOfoperations = new ArrayList(); // for storing operations
        bool operation_pressed = false;
        bool equals_pressed = false;

        public Form1()
        {
            InitializeComponent();
           // this.TransparencyKey = Color.LimeGreen;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; 

            // remove any leading zeroes
            if (result.Text == "0" || operation_pressed || equals_pressed)
                result.Clear();

            equals_pressed = false;
            operation_pressed = false;

            if(b.Text == ".")
            {
                if (!result.Text.Contains("."))
                    result.Text += b.Text;
            }
            else
                result.Text += b.Text;

            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

        private void Operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(value !=0)
            {
                // fire the equals_Click method
                EqualBtn.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = b.Text;
                // since value is a double
                value = Double.Parse(result.Text);
                operation_pressed = true;
                equation.Text = value + " " + operation;
            }
            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case " ":
                    EqualBtn.PerformClick();
                    break;

                case "\r":
                    EqualBtn.PerformClick();
                    break;

                case "=":
                    EqualBtn.PerformClick();
                    break;

                case "+":
                    result.Text = Operators.Add(value, Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = Operators.Sub(value, Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = Operators.Mult(value, Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    if(result.Text == "0")
                    {
                        result.Text = "Cannot Divide by Zero";
                    }
                    else
                        result.Text = Operators.Div(value, Double.Parse(result.Text)).ToString();
                    break;

                case "x^n":
                    result.Text = Operators.x_n(value, Double.Parse(result.Text)).ToString();
                    break;

                case "Sq":
                    result.Text = Operators.Sq(value).ToString();
                    break;

                case "sqrt":
                    result.Text = Operators.Sqrt(value).ToString();
                    break;

                case "nrt":
                    result.Text = Operators.nrt(value, Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }//end switch
            equals_pressed = true;

            if (result.Text == ".")
                value = Double.Parse("0.0"); // does not print but this does avoid an exception
            else
                value = Double.Parse(result.Text);
            
            
            operation = "";
            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

        private void Clear_click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = "0";
            equation.Text = "";
            value = 0;
            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                switch (e.KeyChar.ToString())
                { 
                    case "1":
                        one.PerformClick();
                        break;

                    case "2":
                        two.PerformClick();
                        break;

                    case "3":
                        three.PerformClick();
                        break;

                    case "4":
                        four.PerformClick();
                        break;

                    case "5":
                        five.PerformClick();
                        break;

                    case "6":
                        six.PerformClick();
                        break;

                    case "7":
                        seven.PerformClick();
                        break;

                    case "8":
                        eight.PerformClick();
                        break;

                    case "9":
                        nine.PerformClick();
                        break;

                    case "0":
                        zero.PerformClick();
                        break;

                    case "+":
                        add.PerformClick();
                        break;

                    case "-":
                        sub.PerformClick();
                        break;

                    case "*":
                        mult.PerformClick();
                        break;

                    case "/":
                        div.PerformClick();
                        break;


                    default:
                        break;
                } // end switch
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    del.PerformClick();
                    break;

                case Keys.Back:
                    del.PerformClick();
                    break;

                default:
                    break;
            }

        }

        private void Del_click(object sender, EventArgs e)
        {
            if (result.Text.Length != 1 && result.Text != "0")
                result.Text = result.Text.Remove(result.Text.Length - 1);
            else
                result.Text = "0";

            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

        private void Negate_Click(object sender, EventArgs e)
        {
            if (Double.Parse(result.Text) > 0.0)
                result.Text = '-' + result.Text;
            else if (Double.Parse(result.Text) < 0.0)
                result.Text = result.Text.Remove(0, 1);

            GrabFocus.Focus(); // switches focus to a hidden label. required for \r to keypress equals
        }

       
    }
}
