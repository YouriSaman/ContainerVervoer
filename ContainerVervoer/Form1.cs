using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        private Schip schip;
        private Plaats plaats; //TODO Weet niet of hij nodig is..
        private List<Plaats> Plaatsen;
        private List<Container> Containers;
        public Form1()
        {
            Containers = new List<Container>();
            InitializeComponent();
        }

        private void btnSchipGewicht_Click(object sender, EventArgs e)
        {
            var maxGewicht = Convert.ToInt32(upDownSchipGewicht.Value);
            var minGewicht = Schip.BerekenMinGewicht(maxGewicht);

            schip = new Schip(maxGewicht, minGewicht, 0, 0, null);

            lblGewichtContainers.Text = "0";
            lblAantalContainers.Text = "0";
            lblMaxGewicht.Text = Convert.ToString(maxGewicht);
            lblMinGewicht.Text = Convert.ToString(minGewicht);
            btnSchipGewicht.Enabled = false;
            btnVoegContainerToe.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnVoegContainerToe_Click(object sender, EventArgs e)
        {
            int gewicht = Convert.ToInt16(upDownContainerGewicht.Value);
            bool waardevol = false;
            bool gekoeld = false;
            int aantalWaardevol = 0;

            if (rBtnWaardevol.Checked) waardevol = true;
            if (rBtnGekoeld.Checked) gekoeld = true;

            //Aantal waardevolle containerstellen
            foreach (var container in Containers)
            {
                if (container.Waardevol == true)
                {
                    aantalWaardevol++;
                }
            }

            var nieuweContainer = new Container(gewicht, waardevol, gekoeld);

            //Kijken of de container nog op het schip mag en kan
            if (nieuweContainer.Waardevol == true)
            {
                if (aantalWaardevol + 1 <= 4) //Kijken of het maximum aantal waardevolle containers word overschreden als deze container ook word toegevoegd
                {
                    if (schip.HuidigGewicht + gewicht <= schip.MaxGewicht)
                    {
                        schip.HuidigGewicht += gewicht;

                        //Container toevoegen aan lijst en listbox en de labels aanpassen
                        Containers.Add(nieuweContainer);

                        lblGewichtContainers.Text = Convert.ToString(schip.HuidigGewicht);
                        lBContainers.Items.Add(nieuweContainer.ToString());
                        lblAantalContainers.Text = Convert.ToString(lBContainers.Items.Count);
                    }
                    else
                    {
                        MessageBox.Show("Gewicht zorgt ervoor dat het maximum gewicht op het schip wordt overschreden!");
                    }
                }
                else
                {
                    MessageBox.Show("Het maximum van 4 waardevolle containers word hierbij overschreden!");
                }
            }
        }

        private void btnStartVerdeling_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteContainer_Click(object sender, EventArgs e)
        {
            var containerIndex = lBContainers.SelectedIndex;
            if (containerIndex == -1)
            {
                MessageBox.Show("Selecteer wel een container om te verwijderen!");
            }
            else
            {
                schip.HuidigGewicht = schip.HuidigGewicht - Containers[containerIndex].Gewicht;
                lBContainers.Items.RemoveAt(containerIndex);
                Containers.RemoveAt(containerIndex);

                lblAantalContainers.Text = Convert.ToString(lBContainers.Items.Count);
                lblGewichtContainers.Text = Convert.ToString(schip.HuidigGewicht);
            }
        }
    }
}
