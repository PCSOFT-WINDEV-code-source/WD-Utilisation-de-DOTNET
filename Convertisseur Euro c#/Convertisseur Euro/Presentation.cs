using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Convertisseur_Euro
{
	/// <summary>
	/// Description résumée de Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label LIB_PRESENTATION;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button VALIDE;
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Code généré par le Concepteur Windows Form
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LIB_PRESENTATION = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VALIDE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LIB_PRESENTATION
            // 
            this.LIB_PRESENTATION.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIB_PRESENTATION.Location = new System.Drawing.Point(13, 70);
            this.LIB_PRESENTATION.Name = "LIB_PRESENTATION";
            this.LIB_PRESENTATION.Size = new System.Drawing.Size(781, 386);
            this.LIB_PRESENTATION.TabIndex = 0;
            this.LIB_PRESENTATION.Text = resources.GetString("LIB_PRESENTATION.Text");
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Description de l\'exemple.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright : PC SOFT";
            // 
            // VALIDE
            // 
            this.VALIDE.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VALIDE.Location = new System.Drawing.Point(338, 456);
            this.VALIDE.Name = "VALIDE";
            this.VALIDE.Size = new System.Drawing.Size(120, 34);
            this.VALIDE.TabIndex = 3;
            this.VALIDE.Text = "OK";
            this.VALIDE.Click += new System.EventHandler(this.VALIDE_Click);
            // 
            // Form2
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(818, 511);
            this.Controls.Add(this.VALIDE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LIB_PRESENTATION);
            this.Name = "Form2";
            this.Text = "WD Utilisation de classe WINDEV en DOTNET";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

		}
		#endregion

		private void Form2_Load(object sender, System.EventArgs e)
		{
		
		}

		private void VALIDE_Click(object sender, System.EventArgs e)
		{
			Close();
		}







		
	}
}
