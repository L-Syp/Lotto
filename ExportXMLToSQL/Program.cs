﻿using System;

namespace Lotto
{
    static class Program
    {
        static void Main(string[] args)
        {
            //LoadXML.RunDownloadScript(function : LoadXML.Functions.UPDATE_XML);
            //LoadXML.RunDownloadScript(function: LoadXML.Functions.MAKE_PRETTY_XML);


            //ExportDrawsToSQL exportToSQL = new ExportDrawsToSQL(new SQLUtils.ConnectionString(@"(localdb)\MSSQLLocalDB", "Lotto", true, "RawData"));
            //exportToSQL.ExportDrawsListToSQL(LoadXML.DeserializeXML());

            //bool c = SQLQueries.procedure_ValidateDatabaseRowNumbers(new SQLUtils.ConnectionString(@"(localdb)\MSSQLLocalDB", "Lotto", true, "RawData").ToString());

            LoadXML.RunDownloadScript();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
