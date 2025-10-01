---
title: Zadanie obowiazkowe 1
teach: Łukasz Szymkowski
---

Stwórz zadanie egzaminacyjne z aplikacji desktopowych w formule INF.04. Zadanie powinno zawierać:
- informację o projekcie (do czego służy, co ma być wynikiem działań)
- opis wyglądu aplikacji wraz z makietą wyglądu aplikacji
- Co najmniej 2 okna aplikacji z przesłaniem informacji
- Zmianę obrazu w projekcie
- Pobranie / zapis wyniku pracy do pliku

Załącz stworzoną treść zadania wraz z obrazami.

---

Świetnie — widzę, że załączyłeś własną **makietę aplikacji „Zegary świata”** z prostym i intuicyjnym interfejsem. Na jej podstawie przygotowałem pełną treść **zadania egzaminacyjnego INF.04**.

---

## **Zadanie egzaminacyjne – Aplikacja desktopowa „Zegary świata”**

### **Informacja o projekcie**

Stwórz aplikację desktopową **Zegary świata**, która umożliwia użytkownikowi obserwowanie aktualnego czasu w wybranych miastach z różnych stref czasowych.

Aplikacja ma umożliwiać:

* podgląd zegara analogowego,
* zarządzanie listą miast (dodawanie i usuwanie),
* prezentację różnic czasowych (offsetów od UTC),
* oraz zapis i odczyt listy miast z pliku tekstowego.

---

### **Opis wyglądu aplikacji**

Na ilustracji przedstawiono interfejs aplikacji.

#### **Opis elementów interfejsu:**

1. **Zegar analogowy** – wyświetla aktualny czas dla aktualnie wybranego miasta. Tarcza zegara wskazuje godzinę, minuty i sekundy.
2. **Lista miast** – każde miasto prezentowane jest w osobnym wierszu:

   * Nazwa miasta (np. Tokio)
   * Offset od UTC (np. UTC+9)
   * Przycisk **usuń** (`⨉`) po prawej stronie umożliwia usunięcie miasta z listy.
3. **Pola dodawania miasta:**

   * Pole tekstowe do wpisania nazwy miasta
   * Pole tekstowe lub rozwijana lista do wpisania offsetu UTC (np. `+1`, `-5`, `+9.5`)
   * Przycisk **DODAJ** – dodaje nowe miasto do listy

#### **Makieta aplikacji:**

*(Zamieszczona przez Ciebie ilustracja będzie załącznikiem graficznym w treści zadania)*

---

### **Wymagania funkcjonalne aplikacji**

1. **Zegar analogowy**:

   * Odświeżany w czasie rzeczywistym (co sekundę)
   * Pokazuje czas dla aktualnie **zaznaczonego miasta** na liście (domyślnie pierwszego)

2. **Lista miast**:

   * Wyświetlana w formie listy, każda pozycja zawiera nazwę miasta i offset od UTC
   * Po kliknięciu przycisku `⨉`, dany wpis zostaje usunięty
   * Kliknięcie na miasto (lub jego zaznaczenie) powoduje zmianę zegara głównego na czas dla tego miasta

3. **Dodawanie miasta**:

   * Po wpisaniu nazwy i offsetu UTC, użytkownik klika „DODAJ”, a nowe miasto pojawia się na liście

4. **Zapis i wczytanie danych**:

   * Umożliw zapis aktualnej listy miast do pliku (np. `miasta.txt` lub `miasta.json`)
   * Możliwość wczytania listy miast z pliku i odtworzenia jej w aplikacji

5. **Zmiana obrazu** *(opcjonalna funkcjonalność dodatkowa)*:

   * Użytkownik może ustawić **własne tło** dla aplikacji (np. wczytując obraz z pliku graficznego), które będzie się wyświetlało w tle całego okna

---

### **Przesyłanie informacji między oknami**

Aplikacja powinna posiadać co najmniej **dwa okna**:

1. **Okno główne** – zawiera zegar i listę miast
2. **Okno dialogowe dodawania miasta** – może być oddzielnym oknem modalnym lub wbudowanym formularzem, ale dane z niego muszą być przesyłane do głównego interfejsu

---

### **Wymagania techniczne INF.04**

✅ Co najmniej **2 okna** w aplikacji
✅ **Zegar** z dynamiczną zmianą (czas w czasie rzeczywistym)
✅ **Zmiana obrazu** w projekcie (np. tło lub tarcza zegara)
✅ **Zapis/Wczytanie** danych do/z pliku
✅ Przesyłanie danych między oknami

---

### **Materiały dołączone**

* Makieta interfejsu (plik graficzny PNG)
* Opcjonalnie: plik `miasta_startowe.txt` z początkową listą miast i offsetów

---

### **Propozycja rozszerzeń (dla chętnych / punktów dodatkowych)**

* Możliwość edycji istniejącego miasta (np. zmiana offsetu UTC)
* Tło dostosowane do miasta (np. obrazek tła zależny od lokalizacji)
* Format 24-godzinny lub 12-godzinny (do wyboru)

---

Chcesz, żebym przygotował teraz plik PDF z treścią tego zadania i makietą graficzną?
