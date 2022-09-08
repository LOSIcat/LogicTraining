using System;
using System.Diagnostics;

namespace ParkingLot_System;
class program
{
    /*
    static void Main()
    {
        차량이 진입하면 시간을 기록하고
        정기주차권을 가진 차량인지 확인한다. (새 함수로 구성)

        if(정기주차 차량이면)
            차단기를 연다.(차단기 함수 구성)
        els
        진입 시간이 찍힌 주차증을 출력. (주차증 출력 함수 구성)
        차단기를 연다.(차단기 함수 사용)
    }

    정기주차권차량확인함수()
    {
        정기주차로 등록된 차량인지 확인한다.

            if(정기주차 등록 차량이면)
            정기주차 차량 확인 값을 반환한다.
            else
            비정기주차 차량 확인 값을 반환한다.
    }

    차단기함수()
    {
        차단기를 연다.
    }

    주차권출력함수()
    {
        입차 시간이 찍힌 주차권을 출력한다.
    }

    */
}

class parking
{

    static void Main()
    {
        // 차량이 진입하면 시간을 기록하고
        string timeIn = DateTime.Now.ToString("yyyy-mm-dd:mm:ss");

        // 정기주차권을 가진 차량인지 확인한다. (새 함수 구성)
        int RegularParking = CheckRegularParking();

        // if(정기주차 차량이면)
        if (RegularParking == 1)
        {
            //차단기를 연다. (차단기 함수 구성)
            GateOpen();
        }
        
        else
        {
            //진입 시간이 찍힌 주차증을 출력.(주차증 출력 함수 구성)
            PrintTicket(timeIn);

            // 차단기를 연다. (차단기 함수 사용)
            GateOpen();
        }
    }

    // 정기주차권차량확인함수()
    static int CheckRegularParking()
    {
        // 정기주차로 등록된 차량인지 확인한다.
        int result;
        bool isRegistered = false;

        // if(정기주차 등록 차량이면)
        if (isRegistered == true)
        {
            // 정기주차 차량 확인 값을 반환한다.
            result = 1;
            return result;
        }

        else
        {
            // 비정기주차 차량 확인 값을 반환한다.
            result = 2;
            return result;
        }
    }

    // 차단기 함수()
    static void GateOpen()
    {
        //차단기를 연다.
        Console.WriteLine("차단기가 열립니다");
    }

    // 주차권출력함수()
    static void PrintTicket(string time)
    {
        // 입차 시간이 찍힌 주차권을 출력한다.
        Console.WriteLine("입차시간: {0}", time);
    }
}