#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_side 30

typedef struct phone
{
    int mobile_id;
    char mobile_name[MAX_side];
    long long int mobile_price;
} phone;

struct phone_list
{
    phone phone;
    struct phone_list *next;
};

typedef struct phone_list *node;

void main_menu();
void wait();
void set_color(const char *color);

node createPhone(int id, char *name, long long int price)
{
    node temp;
    temp = (node)malloc(sizeof(struct phone));
    temp->phone.mobile_id = id;
    strcpy(temp->phone.mobile_name, name);
    temp->phone.mobile_price = price;
    temp->next = NULL;
    return temp;
}

node add_to_list(node head, int id, char *name, long long int price)
{
    node temp, p;
    temp = createPhone(id, name, price);
    if (head == NULL)
    {
        head = temp;
    }
    else
    {
        p = head;
        while (p->next != NULL)
        {
            p = p->next;
        }
        p->next = temp;
    }
    return head;
}

node create_list()
{
    node head;
    head = NULL;
    return head;
}

node input_list()
{
    FILE *fp = fopen("PHONE_DATA.TXT", "a");
    node head = create_list();
    int n, id;
    char name[30];
    long long int price;

    system("cls");
    do
    {
        printf("\nENTER THE QUANTITY: ");
        fflush(stdin);
        scanf("%d", &n);
    } while (n <= 0);
    for (int i = 0; i < n; i++)
    {
        if (n != 1)
        {
            set_color("11;32");
            printf("\nPHONE %d\n", i + 1);
            set_color("0");
        }
        printf("\nENTER PHONE ID: ");
        fflush(stdin);
        scanf("%d", &id);
        fprintf(fp, "%d\n", id);
        printf("\nENTER PHONE NAME: ");
        fflush(stdin);
        gets(name);
        printf("\nENTER PRICE: ");
        fprintf(fp, "%s\n", name);
        fflush(stdin);
        scanf("%lld", &price);
        fprintf(fp, "%lld\n", price);
        head = add_to_list(head, id, name, price);
    }
    fclose(fp);
    printf("\nADD PHONE COMPLETE");
    return head;
}

void display_phone_list(node head)
{
    system("cls");
    printf("\n\tALL PHONE\n");
    printf("\n%-8s  %-30s  %-14s", "ID", "PHONE NAME", "PRICE");
    for (node p = head; p != NULL; p = p->next)
    {
        printf("\n");
        printf("\n%-8d  %-30s  %-14lld", p->phone.mobile_id, p->phone.mobile_name, p->phone.mobile_price);

        // printf("\nPHONE ID  : %d", p->phone.mobile_id);
        // printf("\nPHONE NAME: %s", p->phone.mobile_name);
        // printf("\nPRICE     : %lld", p->phone.mobile_price);
        // printf("\n");
    }
}

void input_report()
{
    system("cls");
    FILE *f = fopen("REPORT.TXT", "a");
    char name[MAX_side];
    char respec[255];
    printf("\nENTER NAME: ");
    while (strlen(name) < 1)
    {
        fflush(stdin);
        gets(name);
    }
    fflush(stdout);
    fprintf(f, "%s\n", name);

    printf("\nREPORT: ");
    while (strlen(respec) < 1)
    {
        fflush(stdin);
        gets(respec);
    }
    fflush(stdout);
    fprintf(f, "%s\n", respec);
    fclose(f);
    wait();
}

void watch_report()
{
    system("cls");
    FILE *f = fopen("REPORT.TXT", "r");
    struct content
    {
        char name[MAX_side];
        char respec[255];
    } content[10];
    int i = 0;
    if (f)
    {
        while (1)
        {
            if (feof(f))
            {
                break;
            }
            fflush(stdin);
            fgets(content[i].name, MAX_side, f);
            fflush(stdin);
            fgets(content[i].respec, 256, f);
            i++;
        }
    }
    for (int j = 0; j < (i-1) ; j++) {
        set_color("11;32");
        printf("User    : %s", content[j].name);
        set_color("0");
        printf("\nFeedback: %s", content[j].respec);
        printf("\n\n");

    }
}

void report()
{
    int choice;
    while (1)
    {
        system("cls");
        printf("\n1. FEEDBACK TO STORE");
        printf("\n2. VIEW ORTHER FEEDBACK ");
        printf("\n3. BACK TO MENU");
        printf("\nCHOICE: ");
        fflush(stdin);
        scanf("%d", &choice);
        switch (choice)
        {
        case 1:
            input_report();
            break;
        case 2:
            watch_report();
            wait();
            break;
        case 3:
            main_menu();
        default:
            printf("INPUT ERROR");
        }
    }
}

void display_top_5_heighter_prices()
{
    system("cls");
    typedef struct lay_dien_thoai
    {
        int id;
        char name[30];
        long long int price;
    } dt;
    int i, Run;
    FILE *f = fopen("PHONE_DATA.TXT", "r");
    dt a[30];
    Run = 0;
    if (f)
    {
        i = 0;
        for (;;)
        {

            fflush(stdin);
            fscanf(f, "%d\n", &a[i].id);
            fscanf(f, "%s\n", &a[i].name);
            fscanf(f, "%lld\n", &a[i].price);

            i++;
            Run++;

            if (feof(f))
            {
                break;
            }
        }
    }
    fclose(f);

    for (i = 0; i < (Run); i++)
    {
        for (int j = (i + 1); j < Run; j++)
        {
            if (a[i].price < a[j].price)
            {
                dt b = a[i];
                a[i] = a[j];
                a[j] = b;
            }
        }
    }

    for (i = 0; i < 5; i++)
    {
        if (a[i].id == '\0')
        {
            break;
        };
        printf("\nPHONE NAME: %s", a[i].name);
        printf("\nPRICE: %lld", a[i].price);
        printf("\n");
    }
};

void view_phone(node head)
{
    system("cls");
    int choice;
    while (1)
    {
        do
        {
            system("cls");
            printf("\n1. VIEW ALL PHONE");
            printf("\n2. VIEW TOP 5 PHONE HEIGHTER PICRCE");
            printf("\n3. BACK TO MENU");
            printf("\nCHOICE: ");
            fflush(stdin);
            scanf("%d", &choice);

        } while (choice < 0 || choice > 3);

        switch (choice)
        {
        case 1:
            display_phone_list(head);
            wait();
            break;
        case 2:
            display_top_5_heighter_prices();
            wait();
            break;
        case 3:
            main_menu();
        default:
            printf("INPUT ERROR");
        }
    }
}

void update_phone(node head)
{
    system("cls");
    printf("------UPDATE PHONE PRICE-------");
    int id, count;
    long long int price;
    printf("\nENTER PHONE ID: ");
    fflush(stdin);
    scanf("%d", &id);
    printf("\nUPDATE NEW PRICE: ");
    fflush(stdin);
    scanf("%lld", &price);
    count = 0;
    for (node p = head; p != NULL; p = p->next)
    {
        if (p->phone.mobile_id == id)
        {
            p->phone.mobile_price = price;
            count = 1;
            break;
        }
    }

    if (count == 0)
    {
        printf("\nUPDATA PRICE NOT COMPLETE");
    }
    else
    {
        printf("\nUPDATE COMPLETE");
    }
}

void search(node head)
{
    system("cls");
    int id, count;
    printf("-------SEARCH PHONE BY ID---");
    printf("\nENTER ID: ");
    fflush(stdin);
    scanf("%d", &id);
    count = 0;
    for (node p = head; p != NULL; p = p->next)
    {
        if (p->phone.mobile_id == id)
        {
            printf("\nPHONE NAME: %s", p->phone.mobile_name);
            printf("\nPRICE: %lld", p->phone.mobile_price);
            printf("\n");
            count = 1;
        }
    }
    if (count == 0)
    {
        printf("\nNOT FOUND");
    }
}

void main_menu()
{
    node head;
    int choice;
    while (1)
    {
        do
        {
            system("cls");
            printf("\n===========================");
            printf("\n-----MOBILE PHONE SHOP-----\n");
            printf("===========================\n");
            printf("1. ADD PHONE\n");
            printf("2. SEARCH PHONE BY ID\n");
            printf("3. UPDATE PHONE\n");
            printf("4. VIEW PHONE\n");
            printf("5. SHOP REPORT\n");
            printf("6. EXIT\n");
            printf("========================\n");
            printf("PLEASE, YOUR CHOICE: ");
            fflush(stdin);
            scanf("%d", &choice);
        } while (choice > 6 || choice < 1);

        switch (choice)
        {
        case 1:
            head = input_list();
            wait();
            break;
        case 2:
            search(head);
            wait();
            break;
        case 3:
            update_phone(head);
            wait();
            break;
        case 4:
            view_phone(head);
            break;
        case 5:
            report();
            break;
        case 6:
            exit(0);
        default:
            printf("INPUT ERROR");
        }
    }
}

int main()
{
    main_menu();
    return 0;
};

void wait()
{
    // printf("\n\tPress any key to continue....");
    fflush(stdin);
    getchar();
}

void set_color(const char *color)
{
    char cmd[512];
    sprintf(cmd, "echo|set /p=\"\e[%sm\"", color);
    system(cmd);
}