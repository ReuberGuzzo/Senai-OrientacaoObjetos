﻿using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmSendMail : Form
    {
        public frmSendMail()
        {
            InitializeComponent();
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {
            var mensagem = new MimeMessage();
            mensagem.From.Add (new MailboxAddress(txtNomeCompleto.Text, txtEmail.Text));
            mensagem.To.Add(new MailboxAddress("Reuber", "reuber.rg@gmail.com"));
            
            mensagem.Subject = txtAssunto.Text;
            
            mensagem.Body = new TextPart("plain")
            {
                Text = txtMensagem.Text
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);

                client.Authenticate("reuber.rg@gmail.com", "senha");

                client.Send(mensagem);
                client.Disconnect(true);
            }
        }
    }
}
