using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using WL;

namespace Convertisseur_Euro
{
	/// <summary>
	/// Description résumée de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox COMBO_SOURCE;
		private System.Windows.Forms.TextBox CHAMP_SOURCE;
		private System.Windows.Forms.Label LIB_SOURCE;
		private System.Windows.Forms.ComboBox COMBO_CIBLE;
		private System.Windows.Forms.TextBox CHAMP_CIBLE;
		private System.Windows.Forms.Label LIB_CIBLE;
		private System.Windows.Forms.Button QUITTER;
		/// <summary>
		
		/// Variable nécessaire au concepteur.
		private cEuro gEuro;		//Classe de fonction cEURO.DLL généré depuis WinDev.
		private	bool bSource;		//Champ source en cours de modification.
		private bool bCible;		//Champ cible en cours de modification.

        /// </summary>
		private System.ComponentModel.Container components = null;
		
		public Form1()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();
		
			int Val1=0;
			int Val2=1;
			gEuro=new cEuro(Val1,Val2);
			bSource=false; bCible=false;

		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.label1 = new System.Windows.Forms.Label();
			this.COMBO_SOURCE = new System.Windows.Forms.ComboBox();
			this.CHAMP_SOURCE = new System.Windows.Forms.TextBox();
			this.LIB_SOURCE = new System.Windows.Forms.Label();
			this.COMBO_CIBLE = new System.Windows.Forms.ComboBox();
			this.CHAMP_CIBLE = new System.Windows.Forms.TextBox();
			this.LIB_CIBLE = new System.Windows.Forms.Label();
			this.QUITTER = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(416, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Convertisseur de devises";
			// 
			// COMBO_SOURCE
			// 
			this.COMBO_SOURCE.Items.AddRange(new object[] {
															  "Euro",
															  "Franc Français",
															  "Lire italienne",
															  "Franc Belge",
															  "Franc Luxembourgeois",
															  "Deutsch Mark",
															  "Schilling Autrichien",
															  "Pesete",
															  "Livre Irlandaise",
															  "Florins Néerlandais",
															  "Escudos Portuguais",
															  "Drachme grecque",
															  "Mark Finlandais",
															  "Tolar Slovène"});
			this.COMBO_SOURCE.Location = new System.Drawing.Point(8, 40);
			this.COMBO_SOURCE.Name = "COMBO_SOURCE";
			this.COMBO_SOURCE.Size = new System.Drawing.Size(176, 21);
			this.COMBO_SOURCE.TabIndex = 1;
			this.COMBO_SOURCE.Text = "COMBO_SOURCE";
			this.COMBO_SOURCE.SelectedIndexChanged += new System.EventHandler(this.COMBO_SOURCE_SelectedIndexChanged);
			// 
			// CHAMP_SOURCE
			// 
			this.CHAMP_SOURCE.Location = new System.Drawing.Point(192, 40);
			this.CHAMP_SOURCE.Name = "CHAMP_SOURCE";
			this.CHAMP_SOURCE.Size = new System.Drawing.Size(160, 20);
			this.CHAMP_SOURCE.TabIndex = 2;
			this.CHAMP_SOURCE.Text = "CHAMP_SOURCE";
			this.CHAMP_SOURCE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHAMP_SOURCE_KeyDown);
			this.CHAMP_SOURCE.TextChanged += new System.EventHandler(this.CHAMP_SOURCE_TextChanged);
			// 
			// LIB_SOURCE
			// 
			this.LIB_SOURCE.Location = new System.Drawing.Point(360, 40);
			this.LIB_SOURCE.Name = "LIB_SOURCE";
			this.LIB_SOURCE.Size = new System.Drawing.Size(48, 24);
			this.LIB_SOURCE.TabIndex = 3;
			this.LIB_SOURCE.Text = "EURO";
			this.LIB_SOURCE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// COMBO_CIBLE
			// 
			this.COMBO_CIBLE.Items.AddRange(new object[] {
															 "Euro",
															 "Franc Français",
															 "Lire italienne",
															 "Franc Belge",
															 "Franc Luxembourgeois",
															 "Deutsch Mark",
															 "Schilling Autrichien",
															 "Pesete",
															 "Livre Irlandaise",
															 "Florins Néerlandais",
															 "Escudos Portuguais",
															 "Drachme grecque",
															 "Mark Finlandais",
															 "Tolar Slovène"});
			this.COMBO_CIBLE.Location = new System.Drawing.Point(8, 72);
			this.COMBO_CIBLE.Name = "COMBO_CIBLE";
			this.COMBO_CIBLE.Size = new System.Drawing.Size(176, 21);
			this.COMBO_CIBLE.TabIndex = 4;
			this.COMBO_CIBLE.Text = "COMBO_CIBLE";
			this.COMBO_CIBLE.SelectedIndexChanged += new System.EventHandler(this.COMBO_CIBLE_SelectedIndexChanged);
			// 
			// CHAMP_CIBLE
			// 
			this.CHAMP_CIBLE.Location = new System.Drawing.Point(192, 72);
			this.CHAMP_CIBLE.Name = "CHAMP_CIBLE";
			this.CHAMP_CIBLE.Size = new System.Drawing.Size(160, 20);
			this.CHAMP_CIBLE.TabIndex = 5;
			this.CHAMP_CIBLE.Text = "CHAMP_CIBLE";
			this.CHAMP_CIBLE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CHAMP_CIBLE_KeyDown);
			this.CHAMP_CIBLE.TextChanged += new System.EventHandler(this.CHAMP_CIBLE_TextChanged);
			// 
			// LIB_CIBLE
			// 
			this.LIB_CIBLE.Location = new System.Drawing.Point(360, 72);
			this.LIB_CIBLE.Name = "LIB_CIBLE";
			this.LIB_CIBLE.Size = new System.Drawing.Size(48, 24);
			this.LIB_CIBLE.TabIndex = 6;
			this.LIB_CIBLE.Text = "EURO";
			this.LIB_CIBLE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// QUITTER
			// 
			this.QUITTER.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.QUITTER.Location = new System.Drawing.Point(336, 104);
			this.QUITTER.Name = "QUITTER";
			this.QUITTER.TabIndex = 7;
			this.QUITTER.Text = "Quitter";
			this.QUITTER.Click += new System.EventHandler(this.QUITTER_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.QUITTER;
			this.ClientSize = new System.Drawing.Size(416, 134);
			this.Controls.Add(this.QUITTER);
			this.Controls.Add(this.LIB_CIBLE);
			this.Controls.Add(this.CHAMP_CIBLE);
			this.Controls.Add(this.COMBO_CIBLE);
			this.Controls.Add(this.LIB_SOURCE);
			this.Controls.Add(this.CHAMP_SOURCE);
			this.Controls.Add(this.COMBO_SOURCE);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Convertisseur Euro C#";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Point d'entrée principal de l'application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form2());
			Application.Run(new Form1());
		}
		
		
		private void SourceVersCible()
		{
			//Il faut vérifier que le caractére saisit correspond a un réél
			double d;	//Valeur en réél du champ source
			int Sens;	//Sens de la conversion.
			Sens = 1;
			//Si le champ n'est pas une chaîne vide, on réalise l'opération.
			if (CHAMP_SOURCE.Text != "")
			{
				try
				{
					d=double.Parse(CHAMP_SOURCE.Text);
					//La condition est remplie, on réalise la conversion.
					CHAMP_CIBLE.Text=gEuro.ConvertMonnaie(d,Sens).ToString();
				}
				catch (Exception e2)
				{
					//Affiche un message d'erreur
					MessageBox.Show("La valeur saisie est incorrecte\n" + e2.ToString());
				}
			}
		}

		private void CibleVersSource()
		{
			//Il faut vérifier que le caractére saisit correspond a un réél
			double d;	//Valeur en réél du champ source
			int Sens;	//Sens de la conversion.
			Sens = 2;
			//Si le champ n'est pas une chaîne vide, on réalise l'opération.
			if (CHAMP_CIBLE.Text != "")
			{
				try
				{
					d=double.Parse(CHAMP_CIBLE.Text);
					//La condition est remplie, on réalise la conversion.
					CHAMP_SOURCE.Text=gEuro.ConvertMonnaie(d,Sens).ToString();
				}
				catch (Exception e2)
				{
					//Affiche un message d'erreur
					MessageBox.Show("La valeur saisie est incorrecte"+ e2.ToString());
				}
			}
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//Init des champs.
			bSource=true;bCible=true;
			//Initialise les combos
			COMBO_SOURCE.SelectedIndex=0;
			COMBO_CIBLE.SelectedIndex=1;
			bSource=false;
			CHAMP_CIBLE.Text="100,00";
			bCible=false;
		}

		private void COMBO_SOURCE_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int ValMon;	//Valeur sélectionnée.
			int Ordre;	//Sens du traitement de conversion et du libéllé.
			
			//Fixe la valeur de la monnaie source
			ValMon=COMBO_SOURCE.SelectedIndex+1;
			gEuro.FixeDeviseSource(ValMon);
			//Affiche le libéllé de la monnaie choisie.
			Ordre=1;
			LIB_SOURCE.Text=gEuro.EuroLibelle(Ordre);
			//Affiche la valeur convertie dans la monnaie.
			//CHAMP_CIBLE est la valeur de référence.
			if (bSource == false)
			{
				CibleVersSource();
			}		
		}

	
		private void CHAMP_SOURCE_TextChanged(object sender, System.EventArgs e)
		{
			//Si le champ source n'est pas en cours de saisie.
			//On affiche la valeur convertie.
			if (bCible == false)
            {
				SourceVersCible();
			}			
		}

		private void COMBO_CIBLE_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			int ValMon;	//Valeur sélectionnée.
			int Ordre;	//Sens du traitement de conversion et du libéllé.
			
			//Fixe la valeur de la monnaie source
			ValMon=COMBO_CIBLE.SelectedIndex+1;
			gEuro.FixeDeviseCible(ValMon);

			//Affiche le libéllé de la monnaie choisie.
			Ordre=2;
			LIB_CIBLE.Text=gEuro.EuroLibelle(Ordre);

			//Affiche la conversion dans le champ
			if (bCible == false)
			{
				SourceVersCible();
			}
		}

		private void CHAMP_CIBLE_TextChanged(object sender, System.EventArgs e)
		{
			//Si le champ source n'est pas en cours de saisie.
			//On affiche la valeur convertie.
			if (bSource == false)
			{
				CibleVersSource();
			}
		}

		private void CHAMP_SOURCE_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//On débute la saisie dans le champ Source.
			bSource=true;bCible=false;
		}

		private void CHAMP_CIBLE_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			//On débute la saisie dans le champ Cible.
			bSource=false;bCible=true;
		}

		private void QUITTER_Click(object sender, System.EventArgs e)
		{
			//Ferme la fenêtre.
			Close();		

		}
	}
}
