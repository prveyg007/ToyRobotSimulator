using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Toy_Simulator;


class Program
{
    static void Main(string[] args)
    {
        // Automatically executes when application is started.

        ToyRobotSimulator simulator = new ToyRobotSimulator();

        string binFolderPath = AppDomain.CurrentDomain.BaseDirectory;
        string textFilePath = Path.Combine(binFolderPath, "commands.txt");

        if (binFolderPath == null || binFolderPath.Length == 0)
        {
            Console.WriteLine("Please specify a .txt filepath.");
            return;
        }
        if (File.Exists(textFilePath) && (Path.GetExtension(textFilePath) == ".txt"))
        {
            string[] commands = File.ReadAllLines(textFilePath);
            foreach (var command in commands)
            {
                //Executes the commands
                simulator.ExecuteCommand(command);

            }

        }
    }
}