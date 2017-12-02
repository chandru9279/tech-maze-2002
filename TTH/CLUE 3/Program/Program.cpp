#include "stdafx.h"   // THIS HEADER DOES NOT HAVE ANYTHING TO DO WITH TREASURE HUNT...ITS THERE B'CAUSE VISUAL STUDIO 2005 NEEDS THIS
#include<stdio.h>
#define CONFUSION 10
int old[6];
#include"Confusing.txt"
#include"AndBoring.txt"

int main()
{
	char c;
	int i;
	FILE *fi,*fo;
	old[0] = CONFSUION;
	for(i=1;i<6;i++)
	old[i]=old[i-1]+i;
	fi=fopen("Z:\Input.txt","r");   // OF COURSE, THIS FILE HAS BEEN DELETED
	fo=fopen("Confusion.txt","w");
	if(fi == NULL)
	{
		printf("Cant open input file..");
		scanf("%c",&c);
		return 0;
	}
	c=fgetc(fi);
	while(c!=EOF)
	{		
		flip()?c+=old[1]:c+=old[3];
		fputc(c,fo);
		c=fgetc(fi);
	}
	return 0;
}



