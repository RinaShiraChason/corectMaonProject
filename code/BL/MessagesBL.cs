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

        public List<MessagesDTO> GetMessagesByTo(int userToId, int kidId)
        {

            List<Messages> l = message.GetMessagesByTo(userToId, kidId);
            List<MessagesDTO> lDTO = imapper.Map<List<Messages>, List<MessagesDTO>>(l);
            return lDTO;

        }
        public List<MessagesDTO> GetMessagesNews()
        {

            List<Messages> l = message.GetMessagesNews();
            List<MessagesDTO> lDTO = imapper.Map<List<Messages>, List<MessagesDTO>>(l);
            return lDTO;

        }


        public List<MessagesDTO> GetMessagesByFrom(int userFromId, int kidId)
        {

            List<Messages> l = message.GetMessagesByFrom(userFromId, kidId);
            List<MessagesDTO> lDTO = imapper.Map<List<Messages>, List<MessagesDTO>>(l);
            return lDTO;

        }


        public object AddUpdateMessage(MessagesDTO messages)
        {

            Messages tModel = imapper.Map<MessagesDTO, Messages>(messages);

            message.AddUpdateMessage(tModel);
            return true;
        }

        public List<MessagesDTO> SaveNews(List<MessagesDTO> messages)
        {

            var tModels = imapper.Map<List<MessagesDTO>, List<Messages>>(messages);

            var l = message.SaveNews(tModels);
            var lDTO = imapper.Map<List<Messages>, List<MessagesDTO>>(l);
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
