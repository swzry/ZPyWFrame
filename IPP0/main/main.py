import wpf

from System.Windows import Application, Window

class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'main.xaml')
    

def main(args):
    Application().Run(MyWindow())
