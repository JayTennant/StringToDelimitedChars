# StringToDelimitedChars
C# .NET Console program, converts entered strings to comma-delimited characters. I wrote this because C/C++ does not provide a macro to convert strings to null-terminated comma-delimited sets, and I really needed that, along with the string size (including the null terminator).

This program looks like the following:

    Type in a string to convert to comma-delimited chars (type 'exit' to quit):
    GasLamp.seq
    Size: 12
    As chars:
    'G','a','s','L','a','m','p','.','s','e','q',0,
    As decimal:
    71,97,115,76,97,109,112,46,115,101,113,0,
    
    Type in a string to convert to comma-delimited chars (type 'exit' to quit):
