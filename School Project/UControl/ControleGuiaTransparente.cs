using School_Project.ICFolder;

namespace School_Project.UControl;

public partial class
    ControleGuiaTransparente : UserControl
{
    public ControleGuiaTransparente()
    {
        InitializeComponent();
    }

    private void ControleGuiaTransparente_Load(object sender, EventArgs e)
    {
        //ControleGuiaTransparente controleGuiaTransparente = new();

        //controleGuiaTransparente.ActiveControl = this;
        // controleGuiaTransparente.


        //TransparentTabControl transparentTabControl = new();
        //transparentTabControl.TabPages.Add(new TabPage("Pagina1"));
        //transparentTabControl.TabPages.Add(new TabPage("Pagina2"));
        //transparentTabControl.TabPages.Add(new TabPage("Pagina3"));
        //transparentTabControl.TabPages.Add(new TabPage("Pagina4"));
        //LoadingPages();

        //Controls.Add(transparentTabControl);

        //transparentTabControl.MakeTransparent();

        //transparentTabControl1.MakeTransparent();
    }

    private void LoadingPages()
    {
        TransparentTabControl transparentTabControl = new();
        TransparentTabControl tabControl1 = new();

        //tabControl1 = new TransparentTabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(135, 40);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(743, 558);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(735, 530);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(192, 72);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // ControleGuiaTransparente
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tabControl1);
        Margin = new Padding(20);
        Name = "ControleGuiaTransparente";
        Padding = new Padding(10);
        Size = new Size(989, 700);
        Load += ControleGuiaTransparente_Load;
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }
}