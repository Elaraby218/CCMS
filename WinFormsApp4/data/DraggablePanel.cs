using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp4.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp4.data
{
    public class DraggablePanel
    {
        private int space_leave_to_right = 0;
        private Panel draggablePanel;
        private bool isDragging = false;
        private int xOffset, yOffset;
        private Form parentForm;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        public DraggablePanel(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponents(parentForm);
            Resize_event();
        }

        private void InitializeComponents(Form parentForm)
        {
            // Create the draggable panel
            draggablePanel = new Panel
            {
                BackColor = Color.Transparent,
                Location = new Point(0, 0),
                Name = "panel1",
                Size = new Size(parentForm.ClientSize.Width, 42),
                TabIndex = 26,
                AutoSize = true,

            };

            draggablePanel.Parent = parentForm;

            btnMinimize = new Button
            {
                BackColor = Color.SeaGreen,
                FlatStyle = FlatStyle.Popup,
                ForeColor = SystemColors.ControlDarkDark,
                Image = Resources.icons8_minus_24,
                Name = "minimize_button",
                Margin = new Padding(3, 4, 3, 4),
                Size = new Size(36, 36),
                TabIndex = 29,
                UseVisualStyleBackColor = false
            };

            btnMaximize = new Button
            {
                BackColor = Color.SeaGreen,
                FlatStyle = FlatStyle.Popup,
                ForeColor = SystemColors.ControlDarkDark,
                Image = (Image)Resources.icons8_person_644,
                Margin = new Padding(3, 4, 3, 4),
                Name = "maxmize_button",
                Size = new Size(36, 36),
                TabIndex = 27,
                UseVisualStyleBackColor = false
            };

            btnClose = new Button
            {
                BackColor = Color.SeaGreen,
                FlatStyle = FlatStyle.Popup,
                ForeColor = SystemColors.ControlDarkDark,
                Image = Properties.Resources.icons8_close_30__1_,
                Margin = new Padding(3, 4, 3, 4),
                Name = "Close_buttton",
                Size = new Size(36, 36),
                TabIndex = 30,
                UseVisualStyleBackColor = false
            };

            btnMinimize.Click += buttonMinimize_Click;
            btnMaximize.Click += buttonMaximize_Click;
            btnClose.Click += buttonClose_Click;

            draggablePanel.Controls.Add(btnMinimize);
            draggablePanel.Controls.Add(btnMaximize);
            draggablePanel.Controls.Add(btnClose);

            int rightmostX = parentForm.Width - space_leave_to_right;
            btnMinimize.Location = new Point(rightmostX - 120, 0);
            btnMaximize.Location = new Point(rightmostX - 80, 0);
            btnClose.Location = new Point(rightmostX - 40, 0);

            draggablePanel.MouseDown += DraggablePanel_MouseDown;
            draggablePanel.MouseMove += DraggablePanel_MouseMove;
            draggablePanel.MouseUp += DraggablePanel_MouseUp;

            draggablePanel.BringToFront();

            parentForm.Controls.Add(draggablePanel);
        }

        private void Resize_event()
        {
            parentForm.SizeChanged += ParentForm_SizeChanged;
        }

        private void ParentForm_SizeChanged(object sender, EventArgs e)
        {
            ResizePanel();
        }

        private void ResizePanel()
        {
            // Adjust the size and location of the panel based on the form's size
            draggablePanel.Size = new Size(parentForm.Width, 40);
            draggablePanel.Location = new Point(0, 0);

            int rightmostX = parentForm.Width - space_leave_to_right;
            btnMinimize.Location = new Point(rightmostX - 120, 0);
            btnMaximize.Location = new Point(rightmostX - 80, 0);
            btnClose.Location = new Point(rightmostX - 40, 0);
            draggablePanel.BringToFront();
        }


        private void DraggablePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                xOffset = e.X;
                yOffset = e.Y;
            }
        }

        private void DraggablePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Form parentForm = draggablePanel.Parent as Form;

                if (parentForm != null)
                {
                    int newX = e.X + parentForm.Left - xOffset;
                    int newY = e.Y + parentForm.Top - yOffset;

                    Screen currentScreen = Screen.FromControl(parentForm);
                    Rectangle screenBounds = currentScreen.WorkingArea;

                    parentForm.Left = newX;
                    parentForm.Top = newY;
                }

            }
        }

        private void DraggablePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            parentForm.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            parentForm.WindowState = (parentForm.WindowState == FormWindowState.Maximized) ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

    }
}
