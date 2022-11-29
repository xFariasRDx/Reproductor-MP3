using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_MnM
{
    public partial class Form1 : Form
    {
        bool play = false;
        string[] Archivos_MP3;
        string[] RutasArchivosMP3;
        private string ruta = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void PbCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog CajaDeBusquedaDeArchivos = new OpenFileDialog();
            CajaDeBusquedaDeArchivos.Multiselect= true;
            if (CajaDeBusquedaDeArchivos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                Archivos_MP3 = CajaDeBusquedaDeArchivos.SafeFileNames;
            RutasArchivosMP3 = CajaDeBusquedaDeArchivos.FileNames;
            foreach (var ArchivosMP3 in Archivos_MP3) 
            {
                lstCanciones.Items.Add(ArchivosMP3);
            }
                    
            axWindowsMediaPlayer1.URL= RutasArchivosMP3[0];
        
        }

        /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                 ruta= openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }*/

    private void PbReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void PbPausar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void PbDetener_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = RutasArchivosMP3[lstCanciones.SelectedIndex];
        }

        /*private void pictureBox8_Click(object sender, EventArgs e)
        {
        }*/

        private void PbPlayPause_Click(object sender, EventArgs e)
        {
            switch (play)
            {
                case true:
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        play= false;
                    }
                    break;
                case false:
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        play = true;
                    }
                    break;
            }
        }

        private void PbSiguiente_Click(object sender, EventArgs e)
        {

        }
        //Metodo para sincronizar el Mtrackselect con el de windows media player.
        private void ActualizarDatosTrack()
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                macTrackStatus.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }

            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            { 
                timer1.Stop();
            }

            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                macTrackStatus.Value = 0;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizarDatosTrack();
            macTrackStatus.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            macTrackVolumen.Value = axWindowsMediaPlayer1.settings.volume;
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizarDatosTrack();
        }

        private void macTrackVolumen_ValueChanged(object sender, decimal value)
        {
            axWindowsMediaPlayer1.settings.volume = macTrackVolumen.Value;
        }

        private void macTrackStatus_ValueChanged(object sender, decimal value)
        {
            ActualizarDatosTrack();
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = macTrackStatus.Value;
        }
    }
}
