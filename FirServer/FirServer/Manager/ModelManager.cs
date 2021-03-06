﻿using System;
using System.Collections.Generic;
using log4net;
using FirServer.Define;
using FirServer.Model;
using FirServer.Interface;

namespace FirServer.Manager
{
    public class ModelManager : BaseBehaviour, IManager
    {
        private static Dictionary<string, BaseModel> models = new Dictionary<string, BaseModel>();
        private static readonly ILog logger = LogManager.GetLogger(AppServer.repository.Name, typeof(ModelManager));

        public ModelManager()
        {
        }

        public void Initialize()
        {
            modelMgr = this;

            models.Clear();
        }

        public BaseModel GetModel(string strKey)
        {
            if (models.ContainsKey(strKey))
            {
                return models[strKey];
            }
            return null;
        }

        public void AddModel(string strKey, BaseModel model)
        {
            if (models.ContainsKey(strKey))
            {
                throw new Exception();
            }
            models.Add(strKey, model);
        }

        public void RemoveModel(string strKey)
        {
            if (models.ContainsKey(strKey))
            {
                models.Remove(strKey);
            }
        }

        public void OnDispose()
        {
            modelMgr = null;
        }
    }
}
