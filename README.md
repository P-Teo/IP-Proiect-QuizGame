# QuizGame

## Despre proiect

QuizGame este o aplicație desktop educațională dezvoltată în C# utilizând .NET 8 și Windows Forms, având ca scop evaluarea cunoștințelor de cultură generală prin intermediul unui sistem interactiv de întrebări și răspunsuri.

Aplicația oferă utilizatorilor posibilitatea de a participa la sesiuni de quiz adaptate nivelului de dificultate ales, beneficiind de validarea automată a răspunsurilor, calculul instant al punctajului și afișarea rezultatelor finale. Scopul principal al proiectului este de a combina învățarea cu divertismentul într-un mediu intuitiv și ușor de utilizat.

Proiectul a fost realizat în cadrul disciplinei **Ingineria Programării** și pune accent pe aplicarea principiilor programării orientate pe obiecte, utilizarea șabloanelor de proiectare software și organizarea modulară a codului.

---

## Obiective

- Crearea unei aplicații interactive pentru testarea cunoștințelor generale.
- Automatizarea procesului de evaluare a răspunsurilor.
- Implementarea unui sistem flexibil de dificultate folosind Strategy Pattern.
- Utilizarea unei baze de date locale pentru gestionarea întrebărilor.
- Dezvoltarea unei interfețe grafice intuitive și ușor de utilizat.
- Aplicarea conceptelor de testare software și documentare tehnică.

---

## Funcționalități

### Pentru jucători

- Selectarea nivelului de dificultate:
  - Easy
  - Medium
  - Hard

- Încărcarea automată a întrebărilor corespunzătoare dificultății selectate.

- Afișarea secvențială a întrebărilor și variantelor de răspuns.

- Validarea instantanee a răspunsului selectat.

- Actualizarea scorului în timp real.

- Vizualizarea rezultatului final după terminarea testului.

- Posibilitatea reluării jocului fără repornirea aplicației.

- Acces la documentația Help direct din interfață.

### Pentru administratori și dezvoltatori

- Gestionarea întrebărilor prin intermediul bazei de date SQLite.

- Adăugarea de noi întrebări și răspunsuri.

- Extinderea aplicației prin implementarea unor noi strategii de dificultate.

- Testarea componentelor prin teste unitare.

---

## Arhitectura aplicației

Proiectul este organizat pe mai multe componente pentru a asigura separarea responsabilităților și mentenabilitatea codului.

### QuizGame.Logic

Conține logica principală a aplicației:

- gestionarea sesiunii de joc;
- încărcarea întrebărilor;
- verificarea răspunsurilor;
- calculul scorului;
- controlul fluxului de execuție.

### QuizGame.AccessData

Responsabil pentru:

- inițializarea bazei de date;
- crearea tabelelor SQLite;
- inserarea și extragerea întrebărilor;
- gestionarea persistenței datelor.

### QuizGame.Tests

Include testele unitare utilizate pentru verificarea funcționalităților principale ale aplicației.

### Windows Forms GUI

Reprezintă interfața grafică a aplicației și oferă:

- ecranul principal;
- ecranul de quiz;
- ecranul de rezultate;
- meniul Help;
- informații despre aplicație.

---
## UML Diagrams


| <img src="https://github.com/user-attachments/assets/738b5dbe-6da5-402e-8193-a99252a36505" width="800"> |
|------------------|

| <img src="https://github.com/user-attachments/assets/621f4ef9-b604-4a35-bd9e-ea287c865074" width="800"> |
|------------------|
## Design Pattern utilizat

### Strategy Pattern

Aplicația utilizează șablonul de proiectare **Strategy** pentru a separa logica specifică fiecărui nivel de dificultate de logica generală a jocului.

Avantaje:

- cod mai ușor de extins;
- respectarea principiului Open/Closed;
- posibilitatea adăugării unor noi moduri de joc fără modificarea componentelor existente.

Exemple de strategii:

- EasyStrategy
- MediumStrategy
- HardStrategy

Fiecare strategie:

- filtrează întrebările corespunzătoare nivelului selectat;
- definește modul de calcul al punctajului.

---

## Fluxul aplicației

### 1. Lansarea aplicației

La pornire:

- se verifică existența bazei de date SQLite;
- se creează automat dacă aceasta lipsește;
- sunt inițializate componentele necesare.

### 2. Alegerea dificultății

Utilizatorul selectează nivelul de dificultate dorit din ecranul principal.

### 3. Încărcarea întrebărilor

Sistemul filtrează întrebările folosind strategia asociată nivelului ales.

### 4. Desfășurarea quiz-ului

Pentru fiecare întrebare:

- sunt afișate variantele de răspuns;
- utilizatorul selectează o opțiune;
- sistemul verifică răspunsul;
- scorul este actualizat.

### 5. Finalizarea jocului

După parcurgerea tuturor întrebărilor:

- se afișează scorul final;
- utilizatorul poate relua testul sau închide aplicația.

---

## Baza de date

Aplicația utilizează o bază de date locală SQLite numită:

```text
QuizDatabase.sqlite
```

Tabelul principal:

```sql
Questions
```

Structura unei întrebări:

| Câmp | Descriere |
|--------|------------|
| Id | Identificator unic |
| QuestionText | Textul întrebării |
| QuestionA | Varianta A |
| QuestionB | Varianta B |
| QuestionC | Varianta C |
| QuestionD | Varianta D |
| CorrectOption | Răspunsul corect |
| DifficultyLevel | Nivelul de dificultate |

---

## Tehnologii utilizate

### Limbaj de programare

- C#

### Framework

- .NET 8

### Interfață grafică

- Windows Forms

### Bază de date

- SQLite
- System.Data.SQLite

### Testare

- NUnit

### Documentație

- HelpNDoc
- UML

### Mediu de dezvoltare

- Microsoft Visual Studio

---

## Cerințe de sistem

### Hardware minim

- Procesor Intel Core i3 sau echivalent
- 4 GB RAM
- 100 MB spațiu liber pe disc

### Software

- Windows 10 sau Windows 11
- .NET 8 Runtime

---
## Capturi de ecran

| Home Screen | Quiz Screen |
|------------|----------------------|
| <img src="https://github.com/user-attachments/assets/db7543cd-184c-4d40-a87e-555ae41cc493" width="450"> | <img src="https://github.com/user-attachments/assets/f23c0d62-15c0-4a8b-9c08-4dc726eb157d" width="450"> |

| Quiz Screen | Rezultate finale |
|------------|------------------|
| <img src="https://github.com/user-attachments/assets/171becd2-0203-4c50-940f-f6bc72723224" width="450"> | <img src="https://github.com/user-attachments/assets/c33616fd-acb1-458a-b2b7-fee076f307b3" width="450"> |

## Funcționalități implementate

- [x] Interfață grafică Windows Forms
- [x] Bază de date SQLite
- [x] Inițializare automată a bazei de date
- [x] Selectare dificultate
- [x] Încărcare întrebări din baza de date
- [x] Validare răspunsuri
- [x] Calcul automat al scorului
- [x] Strategy Pattern
- [x] Sistem Help
- [x] Testare unitară
- [x] Documentație UML
- [x] Documentație SRS

---

## 🧾 *License*

This project was created for **educational purposes**.  
