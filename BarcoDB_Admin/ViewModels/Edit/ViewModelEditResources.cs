﻿using BarcoDB_Admin.Models.Db;
using BarcoDB_Admin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcoDB_Admin.ViewModels.Edit
{
    //Amy
    public class ViewModelEditResources : AbstractViewModelBase
    {
        private PlResource _PlResource;
        public PlResource SelectedResouce { get; set; }

        public ViewModelEditResources(int Id) : base()
        {
            //SelectedResouce = resource;
            this._PlResource = _dao.GetResource(Id);
        }

        public PlResource PlResource
        {
            get { return _PlResource; }
            set { _PlResource = value; OnpropertyChanged(); }
        }
    }
}
