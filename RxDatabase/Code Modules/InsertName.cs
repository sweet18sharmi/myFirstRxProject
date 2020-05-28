/*
 * Created by Ranorex
 * User: 166475
 * Date: 28/05/2020
 * Time: 13:30
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace RxDatabase
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("8FDA60B2-AAE1-4720-92F2-10CF3495C08A", ModuleType.UserCode, 1)]
    public class InsertName : ITestModule
    {
    string _varFirstName = "John";
    [TestVariable("789aa507-9a0e-468d-b9a3-554e2378359e")]
    public string varFirstName
    {
    	get { return _varFirstName; }
    	set { _varFirstName = value; }
    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsertName()
        {
        	
            // Do not delete - a parameterless constructor is required!
        }
        
     
        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            RxDatabaseRepository myRepo = new RxDatabaseRepository();
            myRepo.DemoApplication.DatabaseTab.FirstName.TextValue = "John";
            myRepo.DemoApplication.DatabaseTab.LastName.TextValue = "Mill";
        }
    }
}
