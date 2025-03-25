namespace SWapi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbxFilms = new Label();
            DGVFilms = new DataGridView();
            colEpisode_id = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colReleaseDate = new DataGridViewTextBoxColumn();
            colButton = new DataGridViewButtonColumn();
            colOpeningCrawl = new DataGridViewTextBoxColumn();
            colURL = new DataGridViewTextBoxColumn();
            lbxPlanets = new Label();
            listBoxPlanets = new ListBox();
            listBoxHomeworlPerson = new ListBox();
            lbxPersonsHomeworld = new Label();
            button1 = new Button();
            lbxCrawlText = new Label();
            lbxWarningMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVFilms).BeginInit();
            SuspendLayout();
            // 
            // lbxFilms
            // 
            lbxFilms.AutoSize = true;
            lbxFilms.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxFilms.ForeColor = Color.White;
            lbxFilms.Location = new Point(33, 80);
            lbxFilms.Name = "lbxFilms";
            lbxFilms.Size = new Size(63, 20);
            lbxFilms.TabIndex = 0;
            lbxFilms.Text = "lbxFilms";
            // 
            // DGVFilms
            // 
            DGVFilms.AllowUserToAddRows = false;
            DGVFilms.AllowUserToDeleteRows = false;
            DGVFilms.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DGVFilms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DGVFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVFilms.Columns.AddRange(new DataGridViewColumn[] { colEpisode_id, colTitle, colReleaseDate, colButton, colOpeningCrawl, colURL });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DGVFilms.DefaultCellStyle = dataGridViewCellStyle5;
            DGVFilms.GridColor = Color.Black;
            DGVFilms.Location = new Point(33, 103);
            DGVFilms.Name = "DGVFilms";
            DGVFilms.ReadOnly = true;
            DGVFilms.RightToLeft = RightToLeft.No;
            DGVFilms.RowHeadersVisible = false;
            DGVFilms.Size = new Size(460, 212);
            DGVFilms.TabIndex = 1;
            DGVFilms.CellContentClick += DGVFilms_CellContentClick;
            // 
            // colEpisode_id
            // 
            colEpisode_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colEpisode_id.DataPropertyName = "episode_id";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Black;
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            colEpisode_id.DefaultCellStyle = dataGridViewCellStyle2;
            colEpisode_id.HeaderText = "Episode";
            colEpisode_id.Name = "colEpisode_id";
            colEpisode_id.ReadOnly = true;
            colEpisode_id.Width = 77;
            // 
            // colTitle
            // 
            colTitle.DataPropertyName = "title";
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            colTitle.DefaultCellStyle = dataGridViewCellStyle3;
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            colTitle.Width = 180;
            // 
            // colReleaseDate
            // 
            colReleaseDate.DataPropertyName = "release_date";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            colReleaseDate.DefaultCellStyle = dataGridViewCellStyle4;
            colReleaseDate.HeaderText = "Release date";
            colReleaseDate.Name = "colReleaseDate";
            colReleaseDate.ReadOnly = true;
            colReleaseDate.Width = 120;
            // 
            // colButton
            // 
            colButton.HeaderText = "View";
            colButton.Name = "colButton";
            colButton.ReadOnly = true;
            colButton.Text = "View Details";
            colButton.Width = 80;
            // 
            // colOpeningCrawl
            // 
            colOpeningCrawl.DataPropertyName = "opening_crawl";
            colOpeningCrawl.HeaderText = "";
            colOpeningCrawl.Name = "colOpeningCrawl";
            colOpeningCrawl.ReadOnly = true;
            colOpeningCrawl.Visible = false;
            colOpeningCrawl.Width = 5;
            // 
            // colURL
            // 
            colURL.DataPropertyName = "url";
            colURL.HeaderText = "";
            colURL.Name = "colURL";
            colURL.ReadOnly = true;
            colURL.Visible = false;
            colURL.Width = 5;
            // 
            // lbxPlanets
            // 
            lbxPlanets.AutoSize = true;
            lbxPlanets.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxPlanets.ForeColor = Color.White;
            lbxPlanets.Location = new Point(600, 80);
            lbxPlanets.Name = "lbxPlanets";
            lbxPlanets.Size = new Size(58, 20);
            lbxPlanets.TabIndex = 2;
            lbxPlanets.Text = "Planets";
            // 
            // listBoxPlanets
            // 
            listBoxPlanets.BackColor = Color.Black;
            listBoxPlanets.BorderStyle = BorderStyle.FixedSingle;
            listBoxPlanets.ColumnWidth = 150;
            listBoxPlanets.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxPlanets.ForeColor = Color.White;
            listBoxPlanets.FormattingEnabled = true;
            listBoxPlanets.ItemHeight = 20;
            listBoxPlanets.Location = new Point(600, 103);
            listBoxPlanets.Name = "listBoxPlanets";
            listBoxPlanets.Size = new Size(164, 262);
            listBoxPlanets.TabIndex = 3;
            // 
            // listBoxHomeworlPerson
            // 
            listBoxHomeworlPerson.BackColor = Color.Black;
            listBoxHomeworlPerson.BorderStyle = BorderStyle.FixedSingle;
            listBoxHomeworlPerson.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxHomeworlPerson.ForeColor = Color.White;
            listBoxHomeworlPerson.FormattingEnabled = true;
            listBoxHomeworlPerson.ItemHeight = 20;
            listBoxHomeworlPerson.Location = new Point(770, 103);
            listBoxHomeworlPerson.Name = "listBoxHomeworlPerson";
            listBoxHomeworlPerson.Size = new Size(334, 262);
            listBoxHomeworlPerson.TabIndex = 4;
            // 
            // lbxPersonsHomeworld
            // 
            lbxPersonsHomeworld.AutoSize = true;
            lbxPersonsHomeworld.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxPersonsHomeworld.ForeColor = Color.White;
            lbxPersonsHomeworld.Location = new Point(770, 80);
            lbxPersonsHomeworld.Name = "lbxPersonsHomeworld";
            lbxPersonsHomeworld.Size = new Size(156, 20);
            lbxPersonsHomeworld.TabIndex = 5;
            lbxPersonsHomeworld.Text = "Homeworld Characters";
            // 
            // button1
            // 
            button1.Font = new Font("Franklin Gothic Medium", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 22);
            button1.Name = "button1";
            button1.Size = new Size(171, 39);
            button1.TabIndex = 6;
            button1.Text = "Get Star Wars Films";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbxCrawlText
            // 
            lbxCrawlText.AutoSize = true;
            lbxCrawlText.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxCrawlText.ForeColor = Color.FromArgb(255, 128, 0);
            lbxCrawlText.Location = new Point(432, 366);
            lbxCrawlText.Name = "lbxCrawlText";
            lbxCrawlText.Size = new Size(61, 24);
            lbxCrawlText.TabIndex = 7;
            lbxCrawlText.Text = "label1";
            lbxCrawlText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbxWarningMessage
            // 
            lbxWarningMessage.AutoSize = true;
            lbxWarningMessage.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxWarningMessage.ForeColor = Color.Red;
            lbxWarningMessage.Location = new Point(219, 22);
            lbxWarningMessage.Name = "lbxWarningMessage";
            lbxWarningMessage.Size = new Size(61, 24);
            lbxWarningMessage.TabIndex = 8;
            lbxWarningMessage.Text = "label1";
            lbxWarningMessage.TextAlign = ContentAlignment.MiddleCenter;
            lbxWarningMessage.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1181, 882);
            Controls.Add(lbxWarningMessage);
            Controls.Add(lbxCrawlText);
            Controls.Add(button1);
            Controls.Add(lbxPersonsHomeworld);
            Controls.Add(listBoxHomeworlPerson);
            Controls.Add(listBoxPlanets);
            Controls.Add(lbxPlanets);
            Controls.Add(DGVFilms);
            Controls.Add(lbxFilms);
            Name = "Form1";
            Text = "Star Wars Movies from swapi web api";
            ((System.ComponentModel.ISupportInitialize)DGVFilms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbxFilms;
        private DataGridView DGVFilms;
        private Label lbxPlanets;
        private ListBox listBoxPlanets;
        private ListBox listBoxHomeworlPerson;
        private Label lbxPersonsHomeworld;
        private Button button1;
        private Label lbxCrawlText;
        private Label lbxWarningMessage;
        private DataGridViewTextBoxColumn colEpisode_id;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colReleaseDate;
        private DataGridViewButtonColumn colButton;
        private DataGridViewTextBoxColumn colOpeningCrawl;
        private DataGridViewTextBoxColumn colURL;
    }
}
