using System.Drawing.Imaging;

namespace School_Project.WForms.JoelForms;

public partial class FormAbertura : Form
{
    public FormAbertura()
    {
        InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var formCliente = new FormCliente();
        formCliente.ShowDialog();
    }

    private void FormAbertura_Load(object sender, EventArgs e)
    {
        //this.Opacity = .90;
        panel3.BackColor = Color.Transparent;
        panel3.BorderStyle = BorderStyle.None;
        panel3.BackgroundImage = SetImageOpacity(panel3.BackgroundImage, 0.25F);
    }

    public Image SetImageOpacity(Image image, float opacity)
    {
        var bmp = new Bitmap(image.Width, image.Height);
        using (var g = Graphics.FromImage(bmp))
        {
            var matrix = new ColorMatrix();
            matrix.Matrix33 = opacity;
            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                0, 0, image.Width, image.Height,
                GraphicsUnit.Pixel, attributes);
        }

        return bmp;
    }
}