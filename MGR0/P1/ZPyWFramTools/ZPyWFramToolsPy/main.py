import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'ZPyWFramToolsPy.xaml')
    

def ZPyWFramToolsPy(args):
    Application().Run(MyWindow())
