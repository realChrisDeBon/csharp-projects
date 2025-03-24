/* 
 * 
 * Christopher Brian DeBon II
 *  ITD 2343 - Object Oriented Programming Using C#
 *  Spring 2025, due 01/27/2025
 * 
 */

namespace DeBonLab_Project
{
    public enum Contrast
        {
        DarkBackgroundLightText,
        LightBackgroundDarkText
        }
    public partial class mainForm : Form
        {
        public mainForm()
            {
            InitializeComponent();
            }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
            {

            }
        // This function accepts a color and contract parameter to set the main label's background and text color
        public void SetMainColor(Color color, Contrast contrast)
            {
            lblTheDominator.BackColor = color;
            lblTheDominator.ForeColor = contrast == Contrast.DarkBackgroundLightText ? Color.White : Color.Black;
            }
        // This function is for appending text to the main label
        public void AddText(string text)
            {
            lblTheDominator.Text += text;
            }

        // Set to red
        private void btn_red_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_red.BackColor, Contrast.DarkBackgroundLightText);
            }

        // Set to orange
        private void btn_orange_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_orange.BackColor, Contrast.DarkBackgroundLightText);
            }

        // Set to green
        private void btn_green_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_green.BackColor, Contrast.LightBackgroundDarkText);
            }

        // Set to cyan
        private void btn_cyan_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_cyan.BackColor, Contrast.LightBackgroundDarkText);
            }

        // Set to blue
        private void btn_blue_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_blue.BackColor, Contrast.DarkBackgroundLightText);
            }

        // Set to yellow
        private void btn_yellow_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_yellow.BackColor, Contrast.LightBackgroundDarkText);
            }

        // Add 1
        private void btn_one_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 2
        private void btn_two_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 3
        private void btn_three_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 4
        private void btn_four_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 6
        private void btn_six_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 5
        private void btn_five_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 7
        private void btn_seven_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }
        
        // Add 8
        private void btn_eight_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Add 9
        private void btn_nine_Click(object sender, EventArgs e)
            {
            Button button = sender as Button;
            if (button != null)
                {
                AddText(button.Text);
                }
            }

        // Set to olive
        private void btn_olive_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_olive.BackColor, Contrast.DarkBackgroundLightText);
            }

        // Set to purple
        private void btn_purple_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_purple.BackColor, Contrast.DarkBackgroundLightText);
            }

        // Set to pink
        private void btn_pink_Click(object sender, EventArgs e)
            {
            SetMainColor(btn_pink.BackColor, Contrast.LightBackgroundDarkText);
            }

        // Exit the application
        private void btn_exit_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

        // Reset the main label contents and colors
        private void btn_clear_Click(object sender, EventArgs e)
            {
            lblTheDominator.Text = "";
            lblTheDominator.BackColor = Color.White;
            lblTheDominator.ForeColor = Color.Black;
            }
        }
    }
