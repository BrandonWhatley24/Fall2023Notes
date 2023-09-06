namespace InClassCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Btn_Click(object sender, EventArgs e)
        {
            Result_2.Visible = true;
            Result_Lbl.Visible = true;

            //Retrieve Values
            double num1 = Convert.ToInt32(Value1_Txt.Text);
            int num2 = 0;
                
               Int32.TryParse(Value2_Txt.Text, out num2);

            if(Operator_CB.SelectedIndex == 0)
            {
                double result = num1 + num2;
                Result_2.Text = result + "";
            }

            if (Operator_CB.SelectedIndex == 1)
            {
                double result = num1 - num2;
                Result_2.Text = result + "";
            }

            if (Operator_CB.SelectedIndex == 2)
            {
                double result = num1 / num2;
                Result_2.Text = result + "";
            }

            if (Operator_CB.SelectedIndex == 3)
            {
                double result = num1 * num2;
                Result_2.Text = result + "";
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset_Btn_Click(object sender, EventArgs e)
        {
            Value1_Txt.Clear();
            Value2_Txt.Clear();
            Result_2.Clear();
            Operator_CB.SelectedIndex = -1;
            Result_2.Visible = false;
            Result_Lbl.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
          
        }
    }
}