﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.ClientDepartment;

namespace Away_Day_Planner.Presenters
{
    public class ClientDepartmentSelectionPresenter
    {
        private IClientDepartmentSelectionView clientDepartmentSelectionView;
        private IClientModel clientModel;

        public ClientDepartmentSelectionPresenter(IClientDepartmentSelectionView clientDepartmentSelectionView, IClientModel clientModel)
        {
            this.clientDepartmentSelectionView = clientDepartmentSelectionView;
            this.clientModel = clientModel;
            clientDepartmentSelectionView.register(this);
            populateScreen();
        }

        private void populateScreen()
        {
            //Populate clientList box
            Client[] list = clientModel.getClientList();
            String[] names = new String[list.Length];
            for(int i=0; i<list.Length; i++)
            {
                names[i] = list[i].name;
            }

            //Sets Clientlist as datasource in view
            clientDepartmentSelectionView.setClientList(names);

            //Populate departmentList box
            listBoxClientSelectionEvent();
        }

        public void listBoxClientSelectionEvent()
        {
            IDepartment[] departmentList = clientModel.getClientDepartments(clientDepartmentSelectionView.selectedClientIndex);
            
            if(departmentList == null)
            {
                return;
            }

            String[] departmentNames = new String[departmentList.Length];
            for (int i = 0; i < departmentList.Length; i++)
            {
                departmentNames[i] = departmentList[i].name;
            }
            clientDepartmentSelectionView.setDepartmentList(departmentNames);
        }

        public void buttonCreateClientClickEvent()
        {
            CreateClientView createClientView = new CreateClientView();
            ClientModel clientModel = new ClientModel();
            CreateClientPresenter createClientPresenter = new CreateClientPresenter(createClientView, clientModel);
            createClientView.ShowDialog();
            populateScreen();
        }

    }
}
