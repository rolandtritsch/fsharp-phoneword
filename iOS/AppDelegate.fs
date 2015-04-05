﻿namespace Phoneword

open System
open UIKit
open Foundation

[<Register("AppDelegate")>]
type AppDelegate() = 
    inherit UIApplicationDelegate()
    override val Window = null with get, set

    // This method is invoked when the application is ready to run.
    override this.FinishedLaunching(app, options) = 
        this.Window <- new UIWindow(UIScreen.MainScreen.Bounds)
        let viewController = new iOSViewController()
        viewController.View.BackgroundColor <- UIColor.White
        let navController = new UINavigationController(viewController)
        this.Window.RootViewController <- navController
        this.Window.MakeKeyAndVisible()
        true

module Main = 
    [<EntryPoint>]
    let main args = 
        UIApplication.Main(args, null, "AppDelegate")
        0