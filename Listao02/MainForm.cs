using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Listao02
{
	public partial class FrmSorveteria : Form
	{
		public FrmSorveteria()
		{
			InitializeComponent();
		}
		
		void BtncalcularClick(object sender, EventArgs e)
		{
			double valorsorvete=0, peso, valoropcionais=0, valortotal;
			
			peso=Convert.ToDouble(txtpeso.Text);
			if (rbcomum.Checked==true)
				valorsorvete=peso*25;
			if (rbespecial.Checked==true)
				valorsorvete=peso*28.50;
			txtsorvete.Text=Convert.ToString(valorsorvete);
			
			if (cbchocolate.Checked==true)
				valoropcionais+=7;
			if (cbcobertura.Checked==true)
				valoropcionais+=3;
			if (cbamendoim.Checked==true)
				valoropcionais+=5.5;
			txtopcionais.Text=Convert.ToString(valoropcionais);
			
			valortotal=valorsorvete+valoropcionais;
			txttotal.Text=Convert.ToString(valortotal);
		}
		
		void FrmSorveteriaShown(object sender, EventArgs e)
		{
			rbespecial.Checked=false;
			rbcomum.Checked=false;
		}
	}
}
