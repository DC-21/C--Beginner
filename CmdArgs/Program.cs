using System;

class CFG
{
    static public void Main(){
        string CmdLineResults = "";
        CmdLineResults = Environment.CommandLine;

        Console.WriteLine("Command Line Data: \n" + CmdLineResults);
    }
}