using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;//חשוב!
using System.Windows.Forms;//עבור ההודעות!
using System.Data;

namespace BiotestCompany
{
    class Message
    {
        private DateTime messageDT { get; set; }
        //private User sentBy { get; set; }
        private Chat chat { get; set; }
        private string content { get; set; }
        private string attachedPhoto { get; set; }
        private Message asaResponseTo { get; set; }

        public Message(string content, Chat chat, string attachedPhoto, Message asaResponseTo) //add user sent by
        {
            this.messageDT = DateTime.Now;
            //this.user = sentBy;
            this.chat = chat;
            this.content = content;
            this.attachedPhoto = attachedPhoto;
            this.asaResponseTo = asaResponseTo;
        }
    }
}