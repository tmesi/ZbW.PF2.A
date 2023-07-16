namespace MB02
{
    partial class SearchScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnStartA5=new Button();
            BtnStartA4=new Button();
            BtnStartA3=new Button();
            SuspendLayout();
            // 
            // BtnStartA5
            // 
            BtnStartA5.Location=new Point(12, 135);
            BtnStartA5.Name="BtnStartA5";
            BtnStartA5.Size=new Size(187, 50);
            BtnStartA5.TabIndex=0;
            BtnStartA5.Text="Start Aufgabe 5";
            BtnStartA5.UseVisualStyleBackColor=true;
            BtnStartA5.Click+=BtnStartA5_Click;
            // 
            // BtnStartA4
            // 
            BtnStartA4.Location=new Point(12, 78);
            BtnStartA4.Name="BtnStartA4";
            BtnStartA4.Size=new Size(187, 51);
            BtnStartA4.TabIndex=1;
            BtnStartA4.Text="Start Aufgabe 4";
            BtnStartA4.UseVisualStyleBackColor=true;
            BtnStartA4.Click+=BtnStartA4_Click;
            // 
            // BtnStartA3
            // 
            BtnStartA3.Location=new Point(12, 23);
            BtnStartA3.Name="BtnStartA3";
            BtnStartA3.Size=new Size(187, 49);
            BtnStartA3.TabIndex=2;
            BtnStartA3.Text="Start Aufgabe 3";
            BtnStartA3.UseVisualStyleBackColor=true;
            BtnStartA3.Click+=BtnStartA3_Click;
            // 
            // SearchScreen
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(211, 208);
            Controls.Add(BtnStartA3);
            Controls.Add(BtnStartA4);
            Controls.Add(BtnStartA5);
            Name="SearchScreen";
            Text="SearchScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnStartA5;
        private Button BtnStartA4;
        private Button BtnStartA3;
    }
}