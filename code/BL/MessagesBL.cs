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
        public List<Messages> GetAll()
        {

            List<Messages> l = message.GetAll();

            return l;
        }

        public List<MessagesDTO> GetMessagesByTo(int userToId)
        {

            List<Messages> l = message.GetMessagesByTo(userToId);
            List<MessagesDTO> lDTO = imapper.Map<List<Messages>, List<MessagesDTO>>(l);
            return lDTO;

        }

        public List<MessagesDTO> GetMessagesByFrom(int userFromId)
        {

            List<Messages> l = message.GetMessagesByFrom(userFromId);
            List<MessagesDTO> lDTO = imapper.Map<List<Messages>, List<MessagesDTO>>(l);
            return lDTO;

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
