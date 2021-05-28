import math
import speedtest

def menu_selection():
    while True:
        option = input('''What speed do you want to test:\n\n1) Download Speed\n\n2) Upload Speed\n\n3) Ping\n\nYour Choice: ''')
        if option not in {'1', '2', '3'}:
            print('Please enter a valid integer.')
        else:
            break

    get_speed(option)

def get_speed(option):
    try:
        st = speedtest.Speedtest()

        if option == "1":
            convert_size(size_bytes = st.download())
        elif option == "2":
            convert_size(size_bytes = st.upload())
        else:
            servernames = []
            st.get_servers(servernames)
            print(st.results.ping)
    except Exception:
        print("Unable to connect to speedtest servers. Please try again or check your internet settings.")

def convert_size(size_bytes):
   if size_bytes == 0:
       return "0B"
   size_name = ("B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB")
   i = int(math.floor(math.log(size_bytes, 1024)))
   p = math.pow(1024, i)
   s = round(size_bytes / p, 2)
   print("%s %s" % (s, size_name[i]))

menu_selection()