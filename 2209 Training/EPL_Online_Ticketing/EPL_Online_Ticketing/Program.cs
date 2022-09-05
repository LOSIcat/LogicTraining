using System;
using System.Net.Configuration;

namespace EPL_Online_Tickecting
public class program
{
    private void Main()
    {
        사이트에서 경기일, 내용, 경기장을 확인한다

        0번 경기를 선택한다(새함수 구성)

    }
    0번 경기 함수()
    {
        경기 구역을 보이고 선택한다;

        if (경기 구역을 선택했다면)
        개별 좌석을 선택한다(새함수 구성)
        else
            다시 구역을 선택한다

    }
    개별 좌석 함수()
    {
        if (개별 좌석을 선택했다면)
        결재 수단을 정한다
        else
            좌석 선택으로 돌아간다
    }
    결재 수단 함수(int a, int b, int c)
    {
        결재 수단을 선택하고
        결재를 완료한다

        if (결재를 하지 않는다면)
        장바구니에 담는다(새함수 구성)
    }
    장바구니 함수(int a, int b, int c)
    {
        bool 결재를 한다


        bool 결재를 하지 않는다
        값을 반환한다
    }
}

using System;

namespace MacdonaldDT
public class MacdonaldDT
{
    private void Main()
    {
        //사이트에서 경기일, 내용, 경기장을 확인한다
        int date[];
        string match[];
        string stadium[];

        //0번 경기를 선택한다(새함수 구성)
        Match0();
    }
    private void Match0()
    {
        int date[0] = 20xx.xx.xx;
        string match[0] = "Tottenham(Home) vs Chelsea(Away)";
        string stadium[0] = "Tottenham Hotspur Stadium";

        //경기 구역을 보이고 선택한다;
        string[] = "A", "B", "C", "D";

        //if (경기 구역을 선택했다면)
        if (string["A"])
        {
            //개별 좌석을 선택한다(새함수 구성)
            PrivateSeat();
        }
        else
        {
            //다시 구역을 선택한다
            return null;
        }
    }
    private void PrivateSeat(int[])
    {
        //if (개별 좌석을 선택했다면)
        if (int[3] == true)
        {
            //결재 수단을 정한다
            Payment();
        }
        else
        {
            //좌석 선택으로 돌아간다
            return null;
        }
    }
    // 결재 변수
    bool isPayCheck
    private void Payment(int a, int b, int c)
    {
        //결재 수단을 선택하고
        int a = 1;
        //결재를 완료한다
        return a;


        //if (결재를 하지 않는다면)
        if (isPayCheck == false)
        {
            //장바구니에 담는다(새함수 구성)
            ShoppingBasket();
        }

    }
    private void ShoppingBasket(int a, int b, int c)
    {
        //bool 결재를 한다
        bool isPayCheck;

        //if(결재를 하지 않는다)
        if (isPayCheck == false)
        {
            //값을 반환한다
            return null;
        }
    }