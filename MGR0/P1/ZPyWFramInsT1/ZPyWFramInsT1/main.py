import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'ZPyWFramInsT1.xaml')
    

def ZPyWFramInsT1(args):
    Application().Run(MyWindow())
