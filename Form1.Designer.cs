namespace WinApi
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_call = new System.Windows.Forms.Button();
            this.b_what = new System.Windows.Forms.Button();
            this.tb_textClass = new System.Windows.Forms.TextBox();
            this.tb_winname = new System.Windows.Forms.TextBox();
            this.tb_windows = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_call
            // 
            this.b_call.Location = new System.Drawing.Point(31, 30);
            this.b_call.Name = "b_call";
            this.b_call.Size = new System.Drawing.Size(75, 23);
            this.b_call.TabIndex = 0;
            this.b_call.Text = "Вызов MessageBox";
            this.b_call.UseVisualStyleBackColor = true;
            this.b_call.Click += new System.EventHandler(this.b_call_Click);
            // 
            // b_what
            // 
            this.b_what.Location = new System.Drawing.Point(171, 216);
            this.b_what.Name = "b_what";
            this.b_what.Size = new System.Drawing.Size(75, 23);
            this.b_what.TabIndex = 1;
            this.b_what.Text = "Кнопка";
            this.b_what.UseVisualStyleBackColor = true;
            this.b_what.Click += new System.EventHandler(this.b_what_Click);
            // 
            // tb_textClass
            // 
            this.tb_textClass.Location = new System.Drawing.Point(31, 219);
            this.tb_textClass.Name = "tb_textClass";
            this.tb_textClass.Size = new System.Drawing.Size(100, 20);
            this.tb_textClass.TabIndex = 2;
            // 
            // tb_winname
            // 
            this.tb_winname.Location = new System.Drawing.Point(31, 245);
            this.tb_winname.Name = "tb_winname";
            this.tb_winname.Size = new System.Drawing.Size(100, 20);
            this.tb_winname.TabIndex = 2;
            // 
            // tb_windows
            // 
            this.tb_windows.Location = new System.Drawing.Point(301, 32);
            this.tb_windows.Multiline = true;
            this.tb_windows.Name = "tb_windows";
            this.tb_windows.Size = new System.Drawing.Size(375, 287);
            this.tb_windows.TabIndex = 3;
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(682, 32);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(106, 23);
            this.b_search.TabIndex = 4;
            this.b_search.Text = "поиск окон";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.tb_windows);
            this.Controls.Add(this.tb_winname);
            this.Controls.Add(this.tb_textClass);
            this.Controls.Add(this.b_what);
            this.Controls.Add(this.b_call);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_call;
        private System.Windows.Forms.Button b_what;
        private System.Windows.Forms.TextBox tb_textClass;
        private System.Windows.Forms.TextBox tb_winname;
        private System.Windows.Forms.TextBox tb_windows;
        private System.Windows.Forms.Button b_search;
    }
}

