from pyzbar.pyzbar import decode, Decoded
from PIL import Image


def read_qr_code(filename) -> list[Decoded]:
    decoded = decode(Image.open(filename))
    return decoded

value = read_qr_code('C:\Repositories\Dotnet\PythonInDotnet\github.png')[0].data

value = str(value)[2:-1]
print('---------- Python ----------')
print('Qr Code Value: ' + value)
print('---------- End Python ----------')
exit(0)
