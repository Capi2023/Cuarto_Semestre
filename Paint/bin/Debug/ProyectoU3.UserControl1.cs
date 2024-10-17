// ProyectoU3.UserControl1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ProyectoU3.Properties;

public class UserControl1 : UserControl
{
	private ColorDialog cd = new ColorDialog();

	private Color new_color;

	private Bitmap bm;

	private Graphics g;

	private bool paint = false;

	private Point px;

	private Point py;

	private Pen p = new Pen(Color.Black, 1f);

	private Pen erase = new Pen(Color.White, 10f);

	private int index = 0;

	private Point cursor;

	private IContainer components = null;

	private PictureBox pic;

	private Panel panel1;

	private Button btn_Fill;

	private PictureBox color_picker;

	private Button pic_color;

	private Button button1;

	private Button Pintar;

	private Button Colores;

	private Button Fondo;

	private NumericUpDown TamBorrador;

	private NumericUpDown TamLapiz;

	private Button Limpiar;

	private Button Guardar;

	private PictureBox Sticker1;

	private PictureBox Sticker2;

	private Label label1;

	private PictureBox Sticker3;

	public UserControl1()
	{
		InitializeComponent();
		base.Width = 950;
		base.Height = 700;
		bm = new Bitmap(pic.Width, pic.Height);
		g = Graphics.FromImage(bm);
		g.Clear(Color.White);
		pic.Image = bm;
	}

	private void Colores_Click_1(object sender, EventArgs e)
	{
		cd.ShowDialog();
		new_color = cd.Color;
		pic_color.BackColor = cd.Color;
		p.Color = cd.Color;
	}

	private void pic_MouseMove_1(object sender, MouseEventArgs e)
	{
		if (paint)
		{
			if (index == 1)
			{
				px = e.Location;
				g.DrawLine(p, px, py);
				py = px;
			}
			if (index == 2)
			{
				px = e.Location;
				g.DrawLine(erase, px, py);
				py = px;
			}
			if (index == 4)
			{
				g.DrawImage(Sticker1.Image, cursor.X - 40, cursor.Y - 120, 50, 50);
			}
			if (index == 5)
			{
				g.DrawImage(Sticker2.Image, cursor.X - 40, cursor.Y - 120, 50, 50);
			}
			if (index == 6)
			{
				g.DrawImage(Sticker3.Image, cursor.X - 40, cursor.Y - 120, 50, 50);
			}
		}
		pic.Refresh();
		cursor = PointToClient(Cursor.Position);
	}

	private void pic_MouseUp_1(object sender, MouseEventArgs e)
	{
		paint = false;
	}

	private void Pintar_Click(object sender, EventArgs e)
	{
		index = 1;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		index = 2;
	}

	private void pic_MouseDown_1(object sender, MouseEventArgs e)
	{
		paint = true;
		py = e.Location;
	}

	private void color_picker_MouseClick_1(object sender, MouseEventArgs e)
	{
		Point point = set_point(color_picker, e.Location);
		pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
		new_color = pic_color.BackColor;
		p.Color = pic_color.BackColor;
	}

	private static Point set_point(PictureBox pb, Point pt)
	{
		float pX = 1f * (float)pb.Image.Width / (float)pb.Width;
		float pY = 1f * (float)pb.Image.Height / (float)pb.Height;
		return new Point((int)((float)pt.X * pX), (int)((float)pt.Y * pY));
	}

	private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
	{
		Color cx = bm.GetPixel(x, y);
		if (cx == old_color)
		{
			sp.Push(new Point(x, y));
			bm.SetPixel(x, y, new_color);
		}
	}

	private void pic_MouseClick_1(object sender, MouseEventArgs e)
	{
		if (index == 3)
		{
			Point point = set_point(pic, e.Location);
			Fill(bm, point.X, point.Y, new_color);
		}
	}

	public void Fill(Bitmap bm, int x, int y, Color new_clr)
	{
		Color old_color = bm.GetPixel(x, y);
		Stack<Point> pixel = new Stack<Point>();
		pixel.Push(new Point(x, y));
		bm.SetPixel(x, y, new_clr);
		if (old_color == new_clr)
		{
			return;
		}
		while (pixel.Count > 0)
		{
			Point pt = pixel.Pop();
			if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
			{
				validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
				validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
				validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
				validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
			}
		}
	}

	private void btn_Fill_Click(object sender, EventArgs e)
	{
		index = 3;
	}

	private void TamLapiz_ValueChanged(object sender, EventArgs e)
	{
		p.Width = (float)TamLapiz.Value;
	}

	private void TamBorrador_ValueChanged(object sender, EventArgs e)
	{
		p.Width = (float)TamBorrador.Value;
	}

	private void Guardar_Click(object sender, EventArgs e)
	{
		SaveFileDialog sfd = new SaveFileDialog();
		sfd.Filter = "Image(.jpg)|.jpg|().|.";
		if (sfd.ShowDialog() == DialogResult.OK)
		{
			Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
			btm.Save(sfd.FileName, ImageFormat.Jpeg);
		}
	}

	private void Limpiar_Click(object sender, EventArgs e)
	{
		g.Clear(Color.White);
		pic.Image = bm;
		index = 0;
	}

	private void pic_Click(object sender, EventArgs e)
	{
		if (index == 4)
		{
			g.DrawImage(Sticker1.Image, cursor.X - 40, cursor.Y - 120, 50, 50);
		}
		if (index == 5)
		{
			g.DrawImage(Sticker2.Image, cursor.X - 40, cursor.Y - 120, 50, 50);
		}
		if (index == 6)
		{
			g.DrawImage(Sticker3.Image, cursor.X - 40, cursor.Y - 120, 50, 50);
		}
	}

	private void Sticker1_Click(object sender, EventArgs e)
	{
		index = 4;
	}

	private void Sticker2_Click(object sender, EventArgs e)
	{
		index = 5;
	}

	private void Sticker3_Click(object sender, EventArgs e)
	{
		index = 6;
	}

	private void Fondo_Click(object sender, EventArgs e)
	{
		OpenFileDialog ofd = new OpenFileDialog();
		ofd.ShowDialog();
		Bitmap b = new Bitmap(ofd.FileName);
		g.DrawImage(b, new Rectangle(0, 0, pic.Width, pic.Height));
		g.DrawImage(bm, Point.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.panel1 = new System.Windows.Forms.Panel();
		this.Sticker2 = new System.Windows.Forms.PictureBox();
		this.label1 = new System.Windows.Forms.Label();
		this.Sticker3 = new System.Windows.Forms.PictureBox();
		this.Sticker1 = new System.Windows.Forms.PictureBox();
		this.Limpiar = new System.Windows.Forms.Button();
		this.Guardar = new System.Windows.Forms.Button();
		this.TamBorrador = new System.Windows.Forms.NumericUpDown();
		this.TamLapiz = new System.Windows.Forms.NumericUpDown();
		this.Fondo = new System.Windows.Forms.Button();
		this.btn_Fill = new System.Windows.Forms.Button();
		this.color_picker = new System.Windows.Forms.PictureBox();
		this.pic_color = new System.Windows.Forms.Button();
		this.button1 = new System.Windows.Forms.Button();
		this.Pintar = new System.Windows.Forms.Button();
		this.Colores = new System.Windows.Forms.Button();
		this.pic = new System.Windows.Forms.PictureBox();
		this.panel1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Sticker2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Sticker3).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Sticker1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TamBorrador).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.TamLapiz).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.color_picker).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.pic).BeginInit();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
		this.panel1.Controls.Add(this.Sticker2);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.Sticker3);
		this.panel1.Controls.Add(this.Sticker1);
		this.panel1.Controls.Add(this.Limpiar);
		this.panel1.Controls.Add(this.Guardar);
		this.panel1.Controls.Add(this.TamBorrador);
		this.panel1.Controls.Add(this.TamLapiz);
		this.panel1.Controls.Add(this.Fondo);
		this.panel1.Controls.Add(this.btn_Fill);
		this.panel1.Controls.Add(this.color_picker);
		this.panel1.Controls.Add(this.pic_color);
		this.panel1.Controls.Add(this.button1);
		this.panel1.Controls.Add(this.Pintar);
		this.panel1.Controls.Add(this.Colores);
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(800, 80);
		this.panel1.TabIndex = 2;
		this.Sticker2.BackColor = System.Drawing.Color.Transparent;
		this.Sticker2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Sticker2.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Sticker2.Image = ProyectoU3.Properties.Resources.sticker21;
		this.Sticker2.Location = new System.Drawing.Point(582, 7);
		this.Sticker2.Name = "Sticker2";
		this.Sticker2.Size = new System.Drawing.Size(49, 50);
		this.Sticker2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Sticker2.TabIndex = 12;
		this.Sticker2.TabStop = false;
		this.Sticker2.Click += new System.EventHandler(Sticker2_Click);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Modern No. 20", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.Location = new System.Drawing.Point(571, 58);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(66, 18);
		this.label1.TabIndex = 14;
		this.label1.Text = "Stickers";
		this.Sticker3.BackColor = System.Drawing.Color.Transparent;
		this.Sticker3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Sticker3.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Sticker3.Image = ProyectoU3.Properties.Resources.sticker3;
		this.Sticker3.Location = new System.Drawing.Point(637, 7);
		this.Sticker3.Name = "Sticker3";
		this.Sticker3.Size = new System.Drawing.Size(49, 50);
		this.Sticker3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Sticker3.TabIndex = 13;
		this.Sticker3.TabStop = false;
		this.Sticker3.Click += new System.EventHandler(Sticker3_Click);
		this.Sticker1.BackColor = System.Drawing.Color.Transparent;
		this.Sticker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.Sticker1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Sticker1.Image = ProyectoU3.Properties.Resources.sticker11;
		this.Sticker1.Location = new System.Drawing.Point(527, 7);
		this.Sticker1.Name = "Sticker1";
		this.Sticker1.Size = new System.Drawing.Size(49, 50);
		this.Sticker1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.Sticker1.TabIndex = 11;
		this.Sticker1.TabStop = false;
		this.Sticker1.Click += new System.EventHandler(Sticker1_Click);
		this.Limpiar.BackColor = System.Drawing.Color.Transparent;
		this.Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Limpiar.Location = new System.Drawing.Point(705, 43);
		this.Limpiar.Name = "Limpiar";
		this.Limpiar.Size = new System.Drawing.Size(75, 23);
		this.Limpiar.TabIndex = 10;
		this.Limpiar.Text = "Limpiar";
		this.Limpiar.UseVisualStyleBackColor = false;
		this.Limpiar.Click += new System.EventHandler(Limpiar_Click);
		this.Guardar.BackColor = System.Drawing.Color.Transparent;
		this.Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Guardar.Location = new System.Drawing.Point(705, 17);
		this.Guardar.Name = "Guardar";
		this.Guardar.Size = new System.Drawing.Size(75, 23);
		this.Guardar.TabIndex = 9;
		this.Guardar.Text = "Guardar";
		this.Guardar.UseVisualStyleBackColor = false;
		this.Guardar.Click += new System.EventHandler(Guardar_Click);
		this.TamBorrador.Location = new System.Drawing.Point(302, 55);
		this.TamBorrador.Name = "TamBorrador";
		this.TamBorrador.Size = new System.Drawing.Size(50, 20);
		this.TamBorrador.TabIndex = 8;
		this.TamBorrador.ValueChanged += new System.EventHandler(TamBorrador_ValueChanged);
		this.TamLapiz.Location = new System.Drawing.Point(237, 55);
		this.TamLapiz.Name = "TamLapiz";
		this.TamLapiz.Size = new System.Drawing.Size(50, 20);
		this.TamLapiz.TabIndex = 7;
		this.TamLapiz.ValueChanged += new System.EventHandler(TamLapiz_ValueChanged);
		this.Fondo.BackColor = System.Drawing.Color.Transparent;
		this.Fondo.BackgroundImage = ProyectoU3.Properties.Resources.Fondo;
		this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Fondo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Fondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Fondo.Location = new System.Drawing.Point(434, 3);
		this.Fondo.Name = "Fondo";
		this.Fondo.Size = new System.Drawing.Size(50, 50);
		this.Fondo.TabIndex = 6;
		this.Fondo.UseVisualStyleBackColor = false;
		this.Fondo.Click += new System.EventHandler(Fondo_Click);
		this.btn_Fill.BackColor = System.Drawing.Color.Transparent;
		this.btn_Fill.BackgroundImage = ProyectoU3.Properties.Resources.Rellenar;
		this.btn_Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.btn_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btn_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btn_Fill.Location = new System.Drawing.Point(368, 3);
		this.btn_Fill.Name = "btn_Fill";
		this.btn_Fill.Size = new System.Drawing.Size(50, 50);
		this.btn_Fill.TabIndex = 5;
		this.btn_Fill.UseVisualStyleBackColor = false;
		this.btn_Fill.Click += new System.EventHandler(btn_Fill_Click);
		this.color_picker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
		this.color_picker.Image = ProyectoU3.Properties.Resources.setcolor;
		this.color_picker.Location = new System.Drawing.Point(15, 4);
		this.color_picker.Name = "color_picker";
		this.color_picker.Size = new System.Drawing.Size(95, 72);
		this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.color_picker.TabIndex = 4;
		this.color_picker.TabStop = false;
		this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(color_picker_MouseClick_1);
		this.pic_color.BackColor = System.Drawing.Color.White;
		this.pic_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		this.pic_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.pic_color.Location = new System.Drawing.Point(125, 10);
		this.pic_color.Name = "pic_color";
		this.pic_color.Size = new System.Drawing.Size(30, 30);
		this.pic_color.TabIndex = 3;
		this.pic_color.UseVisualStyleBackColor = false;
		this.button1.BackColor = System.Drawing.Color.Transparent;
		this.button1.BackgroundImage = ProyectoU3.Properties.Resources.Borrador;
		this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
		this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.button1.Location = new System.Drawing.Point(302, 3);
		this.button1.Name = "button1";
		this.button1.Size = new System.Drawing.Size(50, 50);
		this.button1.TabIndex = 2;
		this.button1.UseVisualStyleBackColor = false;
		this.button1.Click += new System.EventHandler(button1_Click);
		this.Pintar.BackColor = System.Drawing.Color.Transparent;
		this.Pintar.BackgroundImage = ProyectoU3.Properties.Resources.lapiz;
		this.Pintar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Pintar.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Pintar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Pintar.Location = new System.Drawing.Point(237, 3);
		this.Pintar.Name = "Pintar";
		this.Pintar.Size = new System.Drawing.Size(50, 50);
		this.Pintar.TabIndex = 1;
		this.Pintar.UseVisualStyleBackColor = false;
		this.Pintar.Click += new System.EventHandler(Pintar_Click);
		this.Colores.BackColor = System.Drawing.Color.Transparent;
		this.Colores.BackgroundImage = ProyectoU3.Properties.Resources.colores;
		this.Colores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		this.Colores.Cursor = System.Windows.Forms.Cursors.Hand;
		this.Colores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.Colores.Location = new System.Drawing.Point(171, 3);
		this.Colores.Name = "Colores";
		this.Colores.Size = new System.Drawing.Size(50, 50);
		this.Colores.TabIndex = 0;
		this.Colores.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
		this.Colores.UseVisualStyleBackColor = false;
		this.Colores.Click += new System.EventHandler(Colores_Click_1);
		this.pic.BackColor = System.Drawing.Color.White;
		this.pic.Location = new System.Drawing.Point(15, 99);
		this.pic.Name = "pic";
		this.pic.Size = new System.Drawing.Size(771, 339);
		this.pic.TabIndex = 3;
		this.pic.TabStop = false;
		this.pic.Click += new System.EventHandler(pic_Click);
		this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(pic_MouseClick_1);
		this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(pic_MouseDown_1);
		this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(pic_MouseMove_1);
		this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(pic_MouseUp_1);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
		base.Controls.Add(this.pic);
		base.Controls.Add(this.panel1);
		base.Name = "UserControl1";
		base.Size = new System.Drawing.Size(800, 450);
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.Sticker2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Sticker3).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Sticker1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TamBorrador).EndInit();
		((System.ComponentModel.ISupportInitialize)this.TamLapiz).EndInit();
		((System.ComponentModel.ISupportInitialize)this.color_picker).EndInit();
		((System.ComponentModel.ISupportInitialize)this.pic).EndInit();
		base.ResumeLayout(false);
	}
}
