#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>

void tao_the()
{
    struct tao_the_ATM
    {
        char ten_tai_khoan[30];
        long long so_tai_khoan;
        int pin;
        long long so_du;
    } tt;
    FILE *f = fopen("Account-number.txt", "a");
    while (1)
    {
        printf("\n==========================================");
        printf("\nVTC Academy Bank");
        printf("\n==========================================");
        printf("\nCreate ATM Cards");
        printf("\n------------------------------------------");
        printf("\nInput Account Name: ");
        fflush(stdin);
        gets(tt.ten_tai_khoan);
        fprintf(f, "%s\n", tt.ten_tai_khoan);
        do
        {
            printf("\nInput Account No (about 14 characters): ");
            fflush(stdin);
            scanf("%lld", &tt.so_tai_khoan);
        } while (tt.so_tai_khoan <= 9999999999999 || tt.so_tai_khoan > 99999999999999);
        fprintf(f, "%lld\n", tt.so_tai_khoan);
        do
        {
            printf("\nInput Pin Code (about 6 characters): ");
            fflush(stdin);
            scanf("%d", &tt.pin);
        } while (tt.pin < 99999 || tt.pin > 999999);

        fprintf(f, "%d\n", tt.pin);

        printf("\nInput balance: ");
        scanf("%lld", &tt.so_du);
        fprintf(f, "%lld\n", tt.so_du);

        printf("\nCreate ATM Cards complete!");

        Sleep(2000);
        system("cls");

        printf("\nDo you want to continue creating atm . cards? ");
        char c;
        printf("\n Yes /  No (y/n)  :   ");
        fflush(stdin);
        scanf("%c", &c);

        if (c == 'n')
        {
            system("cls");
            break;
        }
    }
    fclose(f);
}

struct lay_thong_tin
{
    char ten[30];
    long long tk;
    int pin;
    long long du;
};

struct lay_thong_tin a[20];

int so_lan_chay = 0;

void xuat_file_vao_chuong_trinh()
{

    FILE *f = fopen("Account-number.txt", "r");
    int i = 0;
    if (f)
    {
        for (;;)
        {
            fgets(a[i].ten, 30, f);

            fscanf(f, "%lld", &a[i].tk);

            fscanf(f, "%d", &a[i].pin);

            fscanf(f, "%lld", &a[i].du);

            so_lan_chay++;
            i++;

            if (feof(f))
            {
                break;
            }
        }
    }
}

void in_file_vao_tep()
{
    FILE *f = fopen("Account-number.txt", "r+");
    for (int i = 0; i <= so_lan_chay; i++)
    {
        fprintf(f, "%s", a[i].ten);
        fprintf(f, "%lld\n", a[i].tk);
        fprintf(f, "%d\n", a[i].pin);
        fprintf(f, "%lld\n", a[i].du);
    }
    fclose(f);
}


void kiem_tra_so_du(int n)
{
    system("cls");
    xuat_file_vao_chuong_trinh();
    // xuat so du ra man hinh
    printf("\n===================================");
    printf("\nVTC Academy Bank");
    printf("\n===================================");
    printf("\n");
    printf("\nBalance in the account: %lld", a[n].du);
    printf("\n\nBack to menu after:    s\b");
    for (int l = 8; l >= 0; l--)
    {
        if (l < 8)
            printf("\b\b0%d", l);
        else
            printf("\b%d", l);
        Sleep(1000);
    }
}

void bien_lai(int k, long long int so_tien_rut)
{
    xuat_file_vao_chuong_trinh();
    long long int tam;
    system("cls");
    printf("\n================");
    printf("\nVTC Academy Bank");
    printf("\n================");
    printf("\nBien lai rut tien tai ATM");
    printf("\n--------------------------");
    time_t hientai;
    time(&hientai);
    printf("\n%s", ctime(&hientai));
    printf("\nSo tien: %lld VND", so_tien_rut);
    printf("\nNoi dung: Rut tien mat tai ATM");
    printf("\n-----------------------------");
    printf("\nSo du: %lld", a[k].du - so_tien_rut - 2000 - 200);

    a[k].du = a[k].du - so_tien_rut - 22200;
    in_file_vao_tep();

    printf("\nLe phi: 2000 VND");
    printf("\nVAT: 200 VND");
    printf("\n-----------------------------");
    printf("\n\nThank you for using our service!\n");

    printf("\n\nBack to menu after:    s\b");
    for (int l = 8; l >= 0; l--)
    {
        if (l < 8)
            printf("\b\b0%d", l);
        else
            printf("\b%d", l);
        Sleep(1000);
    }
}

void rut_tien(int n)
{

    xuat_file_vao_chuong_trinh();
    int k = n;
    system("cls");
    printf("\n===================================");
    printf("\n       VTC Academy Bank");
    printf("\n===================================");
    printf("\nATM Machine - Withdraw");
    printf("\n-----------------------------------");
    printf("\n1.   100.000 VND");
    printf("\n2.   200.000 VND");
    printf("\n3.   500.000 VND");
    printf("\n4. 1.000.000 VND");
    printf("\n5. 2.000.000 VND");
    printf("\n6. Other number");
    printf("\n-----------------------------------");
    int choice;
    printf("\nYour choice: ");
    scanf("%d", &choice);
    printf("\n-----------------------------------");
    char yesno;
    printf("\nDo you want prinf ?: (y/n): ");
    fflush(stdin);
    scanf("%c", &yesno);
    if (yesno == 'n' || yesno == 'N')
    {
        printf("\nWithdraw succesfully ^^");
        printf("\nThank you :))");
        printf("\n\nBack to menu after:    s\b");
        for (int l = 3; l >= 0; l--)
        {
            if (l < 3)
                printf("\b\b0%d", l);
            else
                printf("\b%d", l);
            Sleep(1000);
        }
    }
    else
    {
        switch (choice)
        {
        case 1:
            if (a[k].du < 100000)
            {
                printf("\ninsufficient balance");
            }
            else
            {
                printf("\nWithdraw succesfully");
                bien_lai(k, 100000);
            }
            break;
        case 2:
            if (a[k].du < 200000)
            {
                printf("\ninsufficient balance");
            }
            else
            {
                printf("\nWithdraw succesfully");
                bien_lai(k, 200000);
            };
            break;
        case 3:
            if (a[k].du < 500000)
            {
                printf("\ninsufficient balance");
            }
            else
            {
                printf("\nWithdraw succesfully");
                bien_lai(k, 500000);
            };
            break;
        case 4:
            if (a[k].du < 1000000)
            {
                printf("\ninsufficient balance");
            }
            else
            {
                printf("\nWithdraw succesfully");
                bien_lai(k, 1000000);
            };
            break;
        case 5:
            if (a[k].du < 2000000)
            {
                printf("\ninsufficient balance");
            }
            else
            {
                printf("\nWithdraw succesfully");
                bien_lai(k, 2000000);
            };
            break;
        case 6:
            printf("\n\t\t\t3000000 VND");
            if (a[k].du < 3000000)
            {
                printf("\ninsufficient balance");
            }
            else
            {
                printf("\nWithdraw succesfully");
                bien_lai(k, 3000000);
            };
            break;
        }
    }
}

void chuyen_khoan(int n)
{
    xuat_file_vao_chuong_trinh();
    printf("\n----------------------------------");
    printf("\nVTC Academy Bank");
    printf("\n===================================\n");
    long long int nguoi_nhan;
    int v = 0, z;

    while (true)
    {
        printf("\nTransfer to Account: ");
        scanf("%lld", &nguoi_nhan);

        for (int m = 0; m < so_lan_chay; m++)
        {
            if (nguoi_nhan == a[m].tk)
            {
                v++;
                z = m;
            }
        }
        if (v == 1)
        {
            break;
        }
        else if (v == 0)
        {
            printf("\nRetype Account No\n ");
        };
    };

    long long int tien;
    printf("\nMoney to transfer: ");
    scanf("%lld", &tien);

    a[n].du = a[n].du - tien;

    a[z].du = a[z].du + tien;
    in_file_vao_tep();
    printf("\n----------------------------------");
    printf("\nTransfer complete!");
    printf("\n----------------------------------");
    printf("\n\nBack to menu after:    s\b");
    for (int l = 5; l >= 0; l--)
    {
        if (l < 5)
            printf("\b\b0%d", l);
        else
            printf("\b%d", l);
        Sleep(1000);
    }
}

void doi_pin(int n)
{
    xuat_file_vao_chuong_trinh();
    printf("\nInput old pin: ");
    int oldPin;
    scanf("%d", &oldPin);
    printf("\nInput New pin:");
    int newPin;
    scanf("%d", &newPin);
    if (a[n].pin == oldPin)
    {
        int PinTam;
        a[n].pin = newPin;
        in_file_vao_tep();

        printf("\nChange Pin complete!");
        printf("\n\nBack to menu after:    s\b");
        for (int l = 8; l >= 0; l--)
        {
            if (l < 8)
                printf("\b\b0%d", l);
            else
                printf("\b%d", l);
            Sleep(1000);
        }
    }
    else
    {
        printf("\n Input Pin ERROR");
        printf("\n\nBack to menu after:    s\b");
        for (int l = 8; l >= 0; l--)
        {
            if (l < 8)
                printf("\b\b0%d", l);
            else
                printf("\b%d", l);
            Sleep(1000);
        }
    }
}

void menu_chinh(int n)
{

    xuat_file_vao_chuong_trinh();
    while (10)
    {
        system("cls");
        printf("\n===================================");
        printf("\nVTC Academy Bank");
        printf("\n===================================");
        printf("\nATM Machine");
        printf("\n-----------------------------------");
        printf("\nAccount No: %lld", a[n].tk);
        printf("\nPin code:  **********");
        printf("\n------------------------------------");
        printf("\nAccount Name: %s ", a[n].ten);
        printf("------------------------------------");
        printf("\n1. Checking account balance");
        printf("\n2. Withdrawal");
        printf("\n3. Transfers");
        printf("\n4. Change PIN");
        printf("\n5. End of transaction");
        printf("\n-------------------------------------");
        int choice;
        printf("\nYour choice: ");
        scanf("%d", &choice);

        switch (choice)
        {
        case 1:
            kiem_tra_so_du(n);
            break;
        case 2:
            rut_tien(n);
            break;
        case 3:
            chuyen_khoan(n);
            break;
        case 4:
            doi_pin(n);
            break;
        case 5:
            exit(0);
        }
    }
}

void mo_phong_cay_atm()
{
    // dang nhap
    long long so_tai_khoan;
    int maPin;
    int i = 0, n = 0;

    FILE *g = fopen("Account-number.txt", "r");
    if (g)
    {
        for (;;)
        {
            fgets(a[i].ten, 30, g);

            fscanf(g, "%lld", &a[i].tk);

            fscanf(g, "%d", &a[i].pin);

            fscanf(g, "%lld", &a[i].du);

            n++;
            i++;

            if (feof(g))
            {
                break;
            }
        }
    }

    int test = 0;
    int vi_tri_tai_khoan;
    int so_lan_nhap = 0;

    system("cls");
    printf("\n===================================");
    printf("\nVTC Academy Bank");
    printf("\n===================================");
    printf("\nLog in Account\n  ");
    while (so_lan_nhap < 3)
    {

        printf("\nInput Account No: ");
        fflush(stdin);
        scanf("%lld", &so_tai_khoan);
        printf("\nInput Pin Code: ");
        fflush(stdin);
        scanf("%d", &maPin);

        for (int j = 0; j < n; j++)
        {
            if (so_tai_khoan == a[j].tk && maPin == a[j].pin)
            {
                test++;
                vi_tri_tai_khoan = j;
            }
        }
        if (test == 0)
        {
            printf("\nLogin failed\n\n");
        }
        else if (test == 1)
        {
            printf("\nLogged in successfully");
            Sleep(1000);
            break;
        }
        so_lan_nhap++;
    }

    // menu chinh

    while (true)
    {
        menu_chinh(vi_tri_tai_khoan);
    }
}

void man_hinh_khoi_dong()
{
    system("color 0A");
    int o = 0;
    while (true)
    {

        system("cls");
        system("color 0A");
        printf("\n  |||                |||  ");
        printf("\n   |||              |||   ");
        printf("\n    |||            |||    ");
        printf("\n     |||          |||     ");
        printf("\n      |||        |||      ");
        printf("\n       |||      |||       ");
        printf("\n        |||    |||        ");
        printf("\n         |||  |||         ");
        printf("\n           ||||           ");

        Sleep(500);
        system("cls");

        printf("\n                           |||||||||||||||||||");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");
        printf("\n                                  ||||        ");

        Sleep(500);
        system("cls");

        printf("\n                                                         ||||||||||        ");
        printf("\n                                                       ||||     ||||       ");
        printf("\n                                                      ||||       ||||      ");
        printf("\n                                                     ||||                  ");
        printf("\n                                                     ||||                  ");
        printf("\n                                                     ||||                  ");
        printf("\n                                                      |||||      |||||     ");
        printf("\n                                                       ||||||   |||||      ");
        printf("\n                                                          |||||||||        ");

        Sleep(500);
        system("cls");

        printf("\n  |||                |||   |||||||||||||||||||           ||||||||||        ");
        printf("\n   |||              |||           ||||                 ||||     ||||       ");
        printf("\n    |||            |||            ||||                ||||       ||||      ");
        printf("\n     |||          |||             ||||               ||||                  ");
        printf("\n      |||        |||              ||||               ||||                  ");
        printf("\n       |||      |||               ||||               ||||                  ");
        printf("\n        |||    |||                ||||                |||||      |||||      ");
        printf("\n         |||  |||                 ||||                 |||||    |||||       ");
        printf("\n           ||||                   ||||                    |||||||||        ");

        Sleep(500);
        system("cls");

        printf("\n  |||                |||   |||||||||||||||||||           ||||||||||        ");
        printf("\n   |||              |||           ||||                 ||||     ||||       ");
        printf("\n    |||            |||            ||||                ||||       ||||      ");
        printf("\n     |||          |||             ||||               ||||                  ");
        printf("\n      |||        |||              ||||               ||||                  ");
        printf("\n       |||      |||               ||||               ||||                  ");
        printf("\n        |||    |||                ||||                |||||      |||||      ");
        printf("\n         |||  |||                 ||||                 |||||    |||||       ");
        printf("\n           ||||                   ||||                    |||||||||        ");
        o++;
        Sleep(600);
        system("cls");
        if (o == 3)
        {
            break;
        }
    }
    printf("\n\n\n");
    printf("\n\tW");
    Sleep(100);
    printf("e");
    Sleep(100);
    printf("l");
    Sleep(100);
    printf("l");
    Sleep(100);
    printf("c");
    Sleep(100);
    printf("o");
    Sleep(100);
    printf("m");
    Sleep(100);
    printf("e");
    Sleep(100);
    printf(" ");
    Sleep(100);
    printf("t");
    Sleep(100);
    printf("o");
    Sleep(100);
    printf(" ");
    Sleep(100);
    printf("o");
    Sleep(100);
    printf("u");
    Sleep(100);
    printf("r");
    Sleep(100);
    printf(" ");
    Sleep(100);
    printf("V");
    Sleep(100);
    printf("T");
    Sleep(100);
    printf("C");
    Sleep(100);
    printf(" ");
    Sleep(100);
    printf("B");
    Sleep(100);
    printf("a");
    Sleep(100);
    printf("n");
    Sleep(100);
    printf("k");
    Sleep(100);
    printf("i");
    Sleep(100);
    printf("n");
    Sleep(100);
    printf("g");
    Sleep(100);
    printf(" ");
    Sleep(100);
    printf("s");
    Sleep(100);
    printf("e");
    Sleep(100);
    printf("r");
    Sleep(100);
    printf("v");
    Sleep(100);
    printf("i");
    Sleep(100);
    printf("c");
    Sleep(100);
    printf("e");
    Sleep(100);
    Sleep(2000);
}

int main()
{
    man_hinh_khoi_dong();
    system("cls");
    system("color 0F");
    int choice;
    while (true)
    {
        printf("\n<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        printf("\n||                                                     ||");
        printf("\n||-----------------------------------------------------||");
        printf("\n||                VTC Academy Bank                     ||");
        printf("\n||-----------------------------------------------------||");
        printf("\n||            ||                   ||                  ||");
        printf("\n|| Sign in    ||        Log in     ||        Exit      ||");
        printf("\n||            ||                   ||                  ||");
        printf("\n||-----------------------------------------------------||");
        printf("\n||     1      ||          2        ||         3        ||");
        printf("\n||            ||                   ||                  ||");
        printf("\n||-----------------------------------------------------||");
        printf("\n||     Your Choice: ");
        fflush(stdin);
        scanf("%d", &choice);
        Sleep(500);
        switch (choice)
        {
        case 1:
            tao_the();
            break;
        case 2:
            mo_phong_cay_atm();
            break;
        case 3:
            exit(0);
        }
    }
    return 0;
}