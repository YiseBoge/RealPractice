import type { NextPage } from "next";

const Footer: NextPage = () => {
  return (
    <div className="relative w-full h-[337px] text-left text-base text-gray-100 font-regular-13">
      <div className="absolute top-[0px] left-[0px] w-[1920px] h-[337px]">
        <div className="absolute h-full w-full top-[0%] right-[0%] bottom-[0%] left-[0%] bg-dark" />
        <img
          className="absolute h-[8.31%] w-[9.25%] top-[35.24%] right-[13.64%] bottom-[56.45%] left-[77.11%] max-w-full overflow-hidden max-h-full"
          alt=""
          src="/social2.svg"
        />
        <img
          className="absolute h-[10.98%] w-[7.45%] top-[27.23%] right-[85.78%] bottom-[61.79%] left-[6.77%] max-w-full overflow-hidden max-h-full"
          alt=""
          src="/logooriginal1.svg"
        />
        <div className="absolute w-[37.37%] top-[35.83%] left-[26.74%] leading-[24px] font-medium inline-block">
          Home Challenges Campanies Leaderboards
        </div>
        <div className="absolute w-[21.44%] top-[81.9%] left-[39.31%] text-sm leading-[22px] text-blue-gray-300 text-center inline-block">
          © Copyright 2022, All Rights Reserved by [Name]
        </div>
      </div>
    </div>
  );
};

export default Footer;
