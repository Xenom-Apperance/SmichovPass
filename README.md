# SmichovPass
## Základní informace
Projekt Kryštofa Bruthanse (1.C) na PVA na SSPŠ.

Zdrojový kód naleznete ve složce "Source". Plnou verzi pak v "Release" (stačí stáhnout .EXE soubor a spustit jej).
## Cíl projektu
Cílem projektu je vytvořit aplikaci na ukládání přihlašovacích údajů (název účtu a heslo), která díky šifrování bude uživatelům sloužit jako zabezpečený "trezor" na jejich hesla v případě, že je zapomenou. Po delším používání tudíž nebudou uživatelé potřebovat znát všechna hesla, ale jen heslo k jejich "trezoru" na hesla.

## Zvolené technologie, předpokládaná náročnost
K realizaci tohoto projektu bude využíváno rozhraní WindowsForms a programovací jazyk C#. K zašifrování dat je používán algoritmus AES (Advanced Encryption Standard) a pro vytvoření klíče na šifrování AES je nejdříve uživatelské heslo zahashováno pomocí algoritmu SHA256.

Předpokládaná náročnost je poměrně vysoká z důvodu pozdního začátku práce s projektu, ale měl by být realizovatelný.
