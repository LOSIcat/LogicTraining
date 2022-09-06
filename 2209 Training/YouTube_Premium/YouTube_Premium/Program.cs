using System;

namespace YouTube_Premium;
public class program
{/*
    private void Main()
    {
        광고가 나오며 "유튜브 프리미엄을 구독하시겠습니까"라고 나온다(새함수 구성);

    }
    프리미엄 구독 함수()
    {
        구독이 맞다면
        1개월 무료, 매월 10,450원 결제

        구독이 아니라면
        광고를 시청한다
    }

    */

    public void Main()
    {
        //광고가 나오며 "유튜브 프리미엄을 구독하시겠습니까"라고 나온다(새함수 구성);

        string request = "유튜브 프리미엄을 구독하시겠습니까?";
        isPremium();

    }
    //구독 메서드
    bool subscribe;
    private void isPremium()
    {

        //구독이 맞다면
        bool subscribe;
        //1개월 무료와 매월 10,450을 결제한다
        int firstMonth = 0;
        int everyMonth = 10450;

        //구독이 아니라면
        subscribe = false;
        //광고를 시청한다
        string ads = "광고를 시청합니다";

    }

}




