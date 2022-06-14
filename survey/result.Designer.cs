namespace survey
{
    partial class result
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rockchic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minimal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityboy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Pink;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.sex,
            this.rockchic,
            this.minimal,
            this.cityboy});
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 91);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(662, 347);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // name
            // 
            this.name.Text = "name";
            this.name.Width = 110;
            // 
            // sex
            // 
            this.sex.Text = "sex";
            this.sex.Width = 110;
            // 
            // rockchic
            // 
            this.rockchic.Text = "rockchic";
            this.rockchic.Width = 110;
            // 
            // minimal
            // 
            this.minimal.Text = "minimal";
            this.minimal.Width = 110;
            // 
            // cityboy
            // 
            this.cityboy.Text = "cityboby";
            this.cityboy.Width = 110;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Pink;
            this.button1.Location = new System.Drawing.Point(685, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "처음으로";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(201, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "선호도 조사 결과";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "result";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader sex;
        private System.Windows.Forms.ColumnHeader rockchic;
        private System.Windows.Forms.ColumnHeader minimal;
        private System.Windows.Forms.ColumnHeader cityboy;
    }
}