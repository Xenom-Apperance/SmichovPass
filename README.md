# SmichovPass
## Základní informace
Projekt Kryštofa Bruthanse (1.C) na PVA na SSPŠ.

Zdrojový kód naleznete ve složce "Source" v této větvi ("main"). Plně zkompilované staiblní verze pak naleznete pod záložkou "Releases".
## Cíl projektu
Cílem projektu je vytvořit aplikaci na ukládání přihlašovacích údajů (název účtu a heslo), která díky šifrování bude uživatelům sloužit jako zabezpečený "trezor" na jejich hesla v případě, že je zapomenou. Po delším používání tudíž nebudou uživatelé potřebovat znát všechna hesla, ale jen heslo k jejich "trezoru" na hesla.

## Zvolené technologie, předpokládaná náročnost
K realizaci tohoto projektu bude využíváno rozhraní WindowsForms a programovací jazyk C#. K zašifrování dat je používán algoritmus AES (Advanced Encryption Standard) a pro vytvoření klíče na šifrování AES je nejdříve uživatelské heslo zahashováno pomocí algoritmu SHA256.

Předpokládaná náročnost je poměrně vysoká z důvodu pozdního začátku práce s projektu, ale měl by být realizovatelný.

## Licence
Štít: [![CC BY 4.0][cc-by-shield]][cc-by]

Tato práce je licencována pod licencí
[Creative Commons Attribution 4.0 International License][cc-by].

[![CC BY 4.0][cc-by-image]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://i.creativecommons.org/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY%204.0-lightgrey.svg
