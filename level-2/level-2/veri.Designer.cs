namespace level_2
{
    partial class veri
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
            this.info = new System.Windows.Forms.DataGridView();
            this.IDlbl = new System.Windows.Forms.Label();
            this.lastnamelbl = new System.Windows.Forms.Label();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.hiredatelbl = new System.Windows.Forms.Label();
            this.ıd = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.hiredate = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.exportemployee = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.info.Location = new System.Drawing.Point(50, 34);
            this.info.Name = "info";
            this.info.RowHeadersWidth = 51;
            this.info.RowTemplate.Height = 24;
            this.info.Size = new System.Drawing.Size(684, 191);
            this.info.TabIndex = 0;
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Location = new System.Drawing.Point(47, 267);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(20, 16);
            this.IDlbl.TabIndex = 1;
            this.IDlbl.Text = "ID";
            // 
            // lastnamelbl
            // 
            this.lastnamelbl.AutoSize = true;
            this.lastnamelbl.Location = new System.Drawing.Point(47, 304);
            this.lastnamelbl.Name = "lastnamelbl";
            this.lastnamelbl.Size = new System.Drawing.Size(65, 16);
            this.lastnamelbl.TabIndex = 2;
            this.lastnamelbl.Text = "last name";
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Location = new System.Drawing.Point(47, 343);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(67, 16);
            this.firstnamelbl.TabIndex = 3;
            this.firstnamelbl.Text = "first name ";
            // 
            // hiredatelbl
            // 
            this.hiredatelbl.AutoSize = true;
            this.hiredatelbl.Location = new System.Drawing.Point(47, 379);
            this.hiredatelbl.Name = "hiredatelbl";
            this.hiredatelbl.Size = new System.Drawing.Size(59, 16);
            this.hiredatelbl.TabIndex = 4;
            this.hiredatelbl.Text = "hire date";
            // 
            // ıd
            // 
            this.ıd.Location = new System.Drawing.Point(127, 262);
            this.ıd.Name = "ıd";
            this.ıd.Size = new System.Drawing.Size(123, 22);
            this.ıd.TabIndex = 5;
            // 
            // lastname
            // 
            this.lastname.Location = new System.Drawing.Point(127, 304);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(123, 22);
            this.lastname.TabIndex = 6;
            // 
            // firstname
            // 
            this.firstname.Location = new System.Drawing.Point(127, 343);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(123, 22);
            this.firstname.TabIndex = 7;
            // 
            // hiredate
            // 
            this.hiredate.Location = new System.Drawing.Point(127, 379);
            this.hiredate.Name = "hiredate";
            this.hiredate.Size = new System.Drawing.Size(123, 22);
            this.hiredate.TabIndex = 8;
            this.hiredate.TextChanged += new System.EventHandler(this.hiredate_TextChanged);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(396, 253);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(118, 41);
            this.view.TabIndex = 9;
            this.view.Text = "view";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(566, 253);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(118, 41);
            this.delete.TabIndex = 10;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(396, 331);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(118, 41);
            this.create.TabIndex = 11;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(566, 331);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(118, 41);
            this.update.TabIndex = 12;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(382, 449);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(169, 47);
            this.import.TabIndex = 13;
            this.import.Text = "import employee";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(589, 449);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(169, 47);
            this.export.TabIndex = 14;
            this.export.Text = "export employee";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // exportemployee
            // 
            this.exportemployee.FormattingEnabled = true;
            this.exportemployee.ItemHeight = 16;
            this.exportemployee.Location = new System.Drawing.Point(794, 34);
            this.exportemployee.Name = "exportemployee";
            this.exportemployee.Size = new System.Drawing.Size(308, 436);
            this.exportemployee.TabIndex = 15;
            this.exportemployee.SelectedIndexChanged += new System.EventHandler(this.exportemployee_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "back to login system";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(925, 503);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(162, 37);
            this.exit.TabIndex = 17;
            this.exit.Text = "exit application";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // veri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 556);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exportemployee);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.update);
            this.Controls.Add(this.create);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.view);
            this.Controls.Add(this.hiredate);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.ıd);
            this.Controls.Add(this.hiredatelbl);
            this.Controls.Add(this.firstnamelbl);
            this.Controls.Add(this.lastnamelbl);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.info);
            this.Name = "veri";
            this.Text = "veri";
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView info;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Label lastnamelbl;
        private System.Windows.Forms.Label firstnamelbl;
        private System.Windows.Forms.Label hiredatelbl;
        private System.Windows.Forms.TextBox ıd;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox hiredate;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.ListBox exportemployee;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exit;
    }
}