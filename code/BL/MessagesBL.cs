using AutoMapper;
using DAL;
using DAL.models;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class MessagesBL
    {
        IMapper imapper;
        MessagesDAL message = new MessagesDAL();
        public MessagesBL()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MyMapper>();
            });
            imapper = config.CreateMapper();
        }
        public List<Messages> getAll()
        {

            List<Messages> l = message.getAll();
           
            return l;
        }

        public object update(MessagesDTO messages)
        {
           
            Messages tModel = imapper.Map<MessagesDTO, Messages>(messages);

            message.update(tModel);
            return true;
        }

        public object Delete(int id)
        {
            bool b = message.Delete(id);

            return b;
        }

        public bool AddMessages(MessagesDTO m)
        {
             Messages tModel = imapper.Map<MessagesDTO, Messages>(m);

            message.AddMessages(tModel);
            return true;

        }

     
    }
}
