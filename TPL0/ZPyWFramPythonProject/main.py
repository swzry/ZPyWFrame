import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, '$safeprojectname$.xaml')
    

def $safeprojectname$(args):
    Application().Run(MyWindow())
