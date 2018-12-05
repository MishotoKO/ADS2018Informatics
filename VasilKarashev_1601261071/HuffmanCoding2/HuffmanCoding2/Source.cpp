﻿/*--Алгоритъм на Хъфман :
1. всички букви - листа на дървото с тегла броя на срещанията на
буквата в текста
2. всички други възли на дървото имат тегла 0
3. в началото разглеждаме всички листа като отделни дървета
4. намираме две дървета с най - малки претеглени дължини
5. построяваме ново дърво, като създаваме нов възел(корен) с
наследници - двете поддървета
6. пресмятаме претеглената дължина на новото дърво(сума от
	претеглените дължини на двете поддървета)
	7. отиваме на 4., ако имаме поне 2 дървета

	-- Построяване на оптимално двоично дърво по
	алгоритъма на Хъфман и пример за следния текст :

програмиране и структури от данни
*/

using namespace std;
#include <iostream>
struct Huf {
	char id;
	int wh;
	Huf *left, *right;
};

struct List {
	List *next;
	Huf *tree;
};

List *head;

void CreateList();
void WriteList();
void DelList(List *l);
void AddList(Huf *h);
Huf *FindDels();
void CreateTree();
void rlrootTree(Huf *h);

void main()
{
	CreateList();
	WriteList();
	CreateTree();
	rlrootTree(head->tree);

	system("Pause");
}

void CreateList()
{
	const int n = 13;
	char ch[n] = { 'a','b','c','d','e','f','g','h','i','j','k','l','m' };
	int   w[n] = { 1,  5,  2,  1,  3,  1,  4,  3,  1,  2,  2,  1,  1 };
	List *l; Huf *h;
	head = 0;
	for (int i = 0; i < n; i++)
	{
		h = new Huf;
		h->id = ch[i]; h->wh = w[i];
		h->left = 0; h->right = 0;
		l = new List;
		l->tree = h;
		l->next = head; head = l;
	}
}

void WriteList()
{
	List *l;
	l = head;
	while (l)
	{
		cout << (l->tree)->id << "  " << (l->tree)->wh << endl;
		l = l->next;
	}
}

void DelList(List *l)
{
	List *lp, *lc;
	if (l == head) { head = l->next; delete l; }
	else
	{
		lp = head; lc = lp->next;
		while (lc != l)
		{
			lp = lc; lc = lc->next;
		}
		lp->next = lc->next; delete lc;
	}
}

void AddList(Huf *h)
{
	List *l;
	l = new List;
	l->tree = h;
	l->next = head;
	head = l;
}

Huf *FindDels()
{
	List *l, *sm;
	Huf *h;
	l = head; sm = l;
	while (l)
	{
		if ((l->tree)->wh < (sm->tree)->wh) sm = l;
		l = l->next;
	}
	h = sm->tree;
	DelList(sm);
	return h;
}

void CreateTree()
{
	Huf *h, *h1, *h2;
	while (head->next)
	{
		h1 = FindDels();
		h2 = FindDels();
		h = new Huf;
		h->id = ' '; h->wh = (h1->wh) + (h2->wh);
		h->left = h1; h->right = h2;
		AddList(h);
	}
}

void rlrootTree(Huf *h)
{
	if (h)
	{
		rlrootTree(h->right);
		rlrootTree(h->left);
		cout << h->id << " : " << h->wh << endl;
	}
}