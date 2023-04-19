import type { NextPage } from "next";

const HeaderNav: NextPage = () => {
  return (
    <div className="relative w-full h-[123px] text-center text-3xl text-gray-500 font-heading-2">
      <div className="absolute w-full top-[0px] right-[0px] left-[0px] bg-primary box-border h-[123px] border-b-[1px] border-solid border-linen">
        <div className="absolute w-[calc(100%_-_672px)] top-[calc(50%_-_20.5px)] right-[305px] left-[367px] h-[41px]">
          <div className="absolute top-[5px] left-[0px] w-[126.88px] h-[27px] overflow-hidden">
            <div className="absolute top-[0px] left-[calc(50%_-_63.44px)] w-[126.88px] h-[27px]" />
          </div>
          <div className="absolute top-[0px] left-[295px] leading-[42px]">
            LeaderBoards
          </div>
          <img
            className="absolute top-[calc(50%_-_11px)] left-[calc(50%_+_497.91px)] w-[22px] h-[22px] overflow-hidden"
            alt=""
            src="/svggamutmcjj5jsvg3.svg"
          />
          <div className="absolute top-[-0.5px] left-[1186.41px] leading-[42px] text-left">
            Log In
          </div>
        </div>
        <div className="absolute top-[40px] left-[288px] leading-[42px]">
          Campanies
        </div>
        <div className="absolute top-[40px] left-[477px] leading-[42px]">
          Challenges
        </div>
      </div>
    </div>
  );
};

export default HeaderNav;
