# _Scrabble_

#### _.Net MVC app that returns the scrabble score value for a word, 2-15-18_

#### By _**Ian Goodrich and Sara Hamilton**_

## Description

_.Net MVC app that returns the scrabble score value for a word_

#### _Scrabble_
* User inputs a word.
* Scrabble score value for the word is returned.
* Values for each letter  
        * A, E, I, O, U, L, N, R, S, T -      1  
        * D, G       -                        2  
        * B, C, M, P   -                      3  
        * F, H, V, W, Y         -             4  
        * K                  -                5  
        * J, X                  -             8  
        * Q, Z                     -          10  

### Specifications

* Take in a word and return a value.
  * sample input : "word"
  * sample output : 8

## Setup/Installation Requirements

* _Clone this GitHub repository_

```
git clone https://github.com/Sara-Hamilton/Scrabble.git
```

* _Install the .NET Framework_

  .NET Core 1.1 SDK (Software Development Kit)

  .NET runtime.

  See https://www.learnhowtoprogram.com/c/getting-started-with-c/installing-c for instructions and links.

* _Run the program_
  1. In the command line, cd into the project folder.
  2. In the command line, type dotnet restore. Enter.  It make take a few minutes to complete this process.
  3. In the command line, type dotnet build. Enter. Any errror messages will be displayed in red.  Errors will need to be corrected before the app can be run. After correcting errors and saving changes, type dotnet build again.  When message says Build succeeded in green, proceed to the next step.
  4. In the command line, type dotnet run. Enter.

* _View program on web browser at port localhost:5000/_

* _Follow the prompts._


## Known Bugs

_There are no known bugs._

## Support and contact details

_To suggest changes, submit a pull request in the GitHub repository._

## Technologies Used

* HTML
* Bootstrap
* C#
* .Net Core 1.1

### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton and Ian Goodrich_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
