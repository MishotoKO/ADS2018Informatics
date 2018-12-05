function str2hex(str) {
    return str.split('').map(function (char) {//splits the string into chars
        var value = char.charCodeAt(0);//gets the code of the first char

        return ((value < 16 ? '0' : '') + value.toString(16)).toUpperCase();
    }).join(' ');//creates one string from the array items
}

function hex2str(hexString) {
    return hexString.split(' ').map(function (string) {//splits a hex string to array of hex string values
        return String.fromCharCode(parseInt(string, 16));//converts the string to char code and parses it to a letter
    }).join('');// joins all array elements to one string
}

function unpackBits(data) {
    var output = '',
        i = 0;

    while (i < data.length) {
        var hex = data.charCodeAt(i);

        if (hex >= 128) {
            hex = 256 - hex;

            for (var j = 0; j <= hex; j++) {
                output += data.charAt(i + 1);
            }

            i++;
        }
        else {
            for (var j = 0; j <= hex; j++) {
                output += data.charAt(i + j + 1);
            }

            i += j;
        }

        i++;
    }

    return output;
}

var hexString = 'FE AA 02 80 00 2A FD AA 03 80 00 2A 22 F7 AA',
    data = unpackBits(hex2str(hexString));

console.log(str2hex(data));