using System;
using System.Net.Configuration;

namespace MacdonaldDT
public class program
{
    private void Main()
    {
        맥도날드에 들어가서 음성계기판의
        직원에게 원하는 메뉴를 주문한다(새함수 구성)

            if (주문이 맞으면)
            다음 코스로 이동한다

            else
            다시 주문하거나 추가로 필요한 것을 말한다
    }
    결제라인 함수()
    {
        주문한 차량이 맞는지 확인한다
            
            if(차량이 맞으면)
            결제한다

            else
            주문확인 또는 차량을 확인한다
    }
    픽업대 함수()
    {
        결제한 차량에 음식을 제공한다
    }
}

using System;

namespace MacdonaldDT
public class MacdonaldDT
{
    private void Main()
    {
        // 맥도날드에 들어가서 
        string Macdonald;
        // 음성계기판의 직원에게 원하는 메뉴를 주문한다(새함수 구성)
        int chooseMenu = MenuSelect();


        // 메뉴가 맞다면
        if (chooseMenu == 1)
        {
            // 다음 코스로 이동한다
            Payment();
        }
        else
        {
            // 다시 주문하거나 필요한 것을 추가한다
            MenuSelect();
        }
    }
    // 결제라인 함수
    private void Payment()
    {
        // 주문한 차량이 맞는지 확인한다
        int payment;
        bool isRigtOrderCar;

        // 차량이 맞으면
        if (isRigtOrderCar == true)
        {        
            // 결제하고 픽업대로 간다
            payment = 14000;
            PickUP();
        }
        else
        {
            // 주문확인 또는 차량을 확인한다
            Console.WriteLine("주문을 확인합니다");
            Console.WriteLine("차량을 확인합니다");
        }
    }
    private void PickUP()
    {
        int isOlderCar;
        string chooseMenu;
        // 결제한 차량에 음식을 제공한다
        isOlderCar = 1;
        chooseMenu = isOlderCar;
        Console.WriteLine("안녕히 가세요");
    }
}