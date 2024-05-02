using System;
using System.Data;
using System.Diagnostics;
using Elliman.Service.DataValidation.DATA;

namespace Elliman.Service.DataValidation.CLASSES
{
	public class OfficeValidator
	{
		public void validateManagers()
		{
			Console.WriteLine("validating managers");
			string sql = "SELECT officeid, name, region, Primary_MLS, Manager_1, Manager_2, Manager_3, Manager_4, Manager_5 FROM [Douglas_Elliman].[dbo].[Offices] where is_Active=1 and ldap is not null";
			DataSet DS = SQL.GetDataset(sql);
			DataTable DT = DS.Tables[0];

			foreach (DataRow office in DT.Rows)
			{
				//Console.WriteLine($"validating {office["name"]}");

				string managerSql = "select username, is_active, display_name from [Douglas_Elliman].[dbo].v_Users where agentid = '" + office["manager_1"] + "'";
                DataSet DSm = SQL.GetDataset(managerSql);
                DataTable DTm = DSm.Tables[0];

				foreach (DataRow manager in DTm.Rows)
				{
                    if ((bool)manager["is_active"] == false)
					{
						Console.WriteLine($"Inactive Manager_1: {manager["display_name"]} - {office["name"]} {office["officeid"]}");
					}

					string dualSql = "select *  FROM [Elliman].[dbo].[DualAgents] where secondaryID = '" + office["manager_1"] + "'";
					DataSet DSd = SQL.GetDataset(dualSql);
					DataTable DTd = DSd.Tables[0];

					foreach(DataRow dual in DTd.Rows)
					{
						Console.WriteLine($"Secondary Manager account set: {manager["display_name"]} - {office["name"]} {office["officeid"]}. Change to: {dual["primaryID"]}");
                    }
                }


                 managerSql = "select username, is_active, display_name from [Douglas_Elliman].[dbo].v_Users where agentid = '" + office["manager_2"] + "'";
                 DSm = SQL.GetDataset(managerSql);
                 DTm = DSm.Tables[0];

                foreach (DataRow manager in DTm.Rows)
                {
                    if ((bool)manager["is_active"] == false)
                    {
                        Console.WriteLine($"Inactive Manager_2: {manager["display_name"]} - {office["name"]} {office["officeid"]}");
                    }

                    string dualSql = "select *  FROM [Elliman].[dbo].[DualAgents] where secondaryID = '" + office["manager_2"] + "'";
                    DataSet DSd = SQL.GetDataset(dualSql);
                    DataTable DTd = DSd.Tables[0];

                    foreach (DataRow dual in DTd.Rows)
                    {
                        Console.WriteLine($"Secondary Manager account set: {manager["display_name"]} - {office["name"]} {office["officeid"]}. Change to: {dual["primaryID"]}");
                    }
                }

                managerSql = "select username, is_active, display_name from [Douglas_Elliman].[dbo].v_Users where agentid = '" + office["manager_3"] + "'";
                DSm = SQL.GetDataset(managerSql);
                DTm = DSm.Tables[0];

                foreach (DataRow manager in DTm.Rows)
                {
                    if ((bool)manager["is_active"] == false)
                    {
                        Console.WriteLine($"Inactive Manager_3: {manager["display_name"]} - {office["name"]} {office["officeid"]}");
                    }

                    string dualSql = "select *  FROM [Elliman].[dbo].[DualAgents] where secondaryID = '" + office["manager_3"] + "'";
                    DataSet DSd = SQL.GetDataset(dualSql);
                    DataTable DTd = DSd.Tables[0];

                    foreach (DataRow dual in DTd.Rows)
                    {
                        Console.WriteLine($"Secondary Manager account set: {manager["display_name"]} - {office["name"]} {office["officeid"]}. Change to: {dual["primaryID"]}");
                    }
                }
            }

        }
	}
}

