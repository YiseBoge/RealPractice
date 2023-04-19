import type { NextPage } from "next";

const ChallengeQuestion: NextPage = () => {
  return (
    <div className="relative w-full h-[1614px] text-left text-9xl text-dark font-heading-2">
      <div className="absolute top-[0px] left-[0px] bg-whitesmoke-400 w-[1945px] h-[1614px]">
        <div className="absolute top-[123px] left-[0px] w-[1920px] h-[1327px]">
          <div className="absolute top-[-6px] left-[-2px] bg-primary w-[1946px] h-[280px]" />
          <div className="absolute top-[25px] left-[calc(50%_-_510px)] w-[1020px] h-[1035.98px]">
            <div className="absolute w-[calc(100%_-_40px)] top-[0px] right-[20px] left-[20px] h-[37.8px]">
              <div className="absolute top-[calc(50%_-_18.9px)] left-[0px] overflow-hidden flex flex-row py-0 pr-[0.839996337890625px] pl-0 items-start justify-start">
                <div className="relative tracking-[-0.56px] leading-[37.8px] font-thin">
                  Problems
                </div>
              </div>
              <textarea className="[border:none] bg-[transparent] font-material-icons text-5xl absolute top-[4px] left-[117.84px] leading-[24px] text-gray-800 text-left" />
              <div className="absolute top-[calc(50%_-_18.9px)] left-[146.84px] overflow-hidden flex flex-row py-0 pr-[1.3300018310546875px] pl-0 items-start justify-start">
                <div className="relative tracking-[-0.56px] leading-[37.8px] font-thin">
                  Simple problem
                </div>
              </div>
            </div>
            <div className="absolute top-[calc(50%_-_446.19px)] left-[20px] w-[369.39px] h-[33px] text-sm">
              <div className="absolute top-[0px] left-[0px] flex flex-row pt-0 pb-[13px] pr-[14.480003356933594px] pl-[15px] items-start justify-start border-b-[3px] border-solid border-gray-900">
                <a
                  className="relative leading-[20px] text-[inherit] [text-decoration:none]"
                  href="https://www.eolymp.com/en/problems/1"
                  target="_blank"
                >
                  Statement
                </a>
              </div>
              <div className="absolute top-[0px] left-[109.48px] leading-[20px]">
                Solutions
              </div>
              <a
                className="absolute top-[0px] left-[197.8px] leading-[20px] text-[inherit] [text-decoration:none]"
                href="https://www.eolymp.com/en/problems/1/statistics"
                target="_blank"
              >
                Statistics
              </a>
              <a
                className="absolute top-[0px] left-[286px] leading-[20px] text-[inherit] [text-decoration:none]"
                href="https://www.eolymp.com/en/problems/1/discussion"
                target="_blank"
              >
                Discussion
              </a>
            </div>
            <div className="absolute top-[124.8px] left-[20px] rounded bg-light shadow-[0px_2px_2px_rgba(0,_0,_0,_0.14),_0px_3px_1px_-2px_rgba(0,_0,_0,_0.2),_0px_1px_5px_rgba(0,_0,_0,_0.12)] w-[980px] h-[911.19px] overflow-hidden text-5xl text-blur">
              <div className="absolute top-[30px] left-[30px] w-[920px] h-[673.19px] text-gray-400">
                <div className="absolute top-[-1px] left-[0px] text-[32px] tracking-[-0.64px] leading-[43.2px]">
                  Simple problem
                </div>
                <div className="absolute top-[63.18px] left-[-30px] flex flex-col py-[31px] px-[25px] items-start justify-start text-xl text-blur font-material-icons border-t-[1px] border-solid border-gainsboro-200 border-b-[1px]">
                  <div className="flex flex-row py-[5px] pr-[772px] pl-[5px] items-start justify-start gap-[10px]">
                    <div className="overflow-hidden flex flex-row items-start justify-start">
                      <div className="relative leading-[20px]"></div>
                    </div>
                    <div className="overflow-hidden flex flex-row items-start justify-start text-sm font-heading-2">
                      <div className="relative leading-[20px]">
                        <span>{`Time limit `}</span>
                        <b>1</b>
                        <span> second</span>
                      </div>
                    </div>
                  </div>
                  <div className="flex flex-row py-[5px] pr-[757px] pl-[5px] items-start justify-start gap-[10px]">
                    <div className="overflow-hidden flex flex-row items-start justify-start">
                      <div className="relative leading-[20px]"></div>
                    </div>
                    <div className="overflow-hidden flex flex-row items-start justify-start text-sm font-heading-2">
                      <div className="relative leading-[20px]">
                        <span>{`Memory limit `}</span>
                        <b>256</b>
                        <span> MiB</span>
                      </div>
                    </div>
                  </div>
                </div>
                <div className="absolute top-[215.18px] left-[0px] text-mini leading-[24px]">
                  Write a program which reads a two-digit number and prints
                  every digit, separated by a space.
                </div>
                <div className="absolute top-[264.18px] left-[0px] flex flex-col items-start justify-start gap-[10px]">
                  <div className="relative leading-[48px]">Input data</div>
                  <div className="flex flex-row py-0 pr-[673px] pl-0 items-start justify-start text-mini">
                    <div className="relative leading-[24px]">
                      <span>{`One integer from `}</span>
                      <b>10</b>
                      <span>{` to `}</span>
                      <b>99</b>
                      <span> inclusively.</span>
                    </div>
                  </div>
                </div>
                <div className="absolute top-[371.18px] left-[0px] flex flex-col items-start justify-start gap-[10px]">
                  <div className="relative leading-[48px]">Output data</div>
                  <div className="flex flex-col items-start justify-start gap-[16px] text-mini">
                    <div className="relative leading-[24px]">
                      Print two digits separated by a space.
                    </div>
                    <div className="flex flex-row py-0 pr-[228px] pl-0 items-start justify-start">
                      <div className="relative leading-[24px]">
                        <span>
                          <b>Important!</b>
                        </span>
                        <span>
                          <span>{` In case you have any troubles solving this problem, please check out examples on `}</span>
                          <span className="text-darkcyan">Help page</span>
                          <span className="text-gray-400">.</span>
                        </span>
                      </div>
                    </div>
                  </div>
                </div>
                <div className="absolute top-[518.18px] left-[0px] flex flex-col items-start justify-start gap-[20px]">
                  <div className="relative leading-[48px]">Examples</div>
                  <div className="flex flex-row items-start justify-start gap-[16px] text-sm">
                    <div className="flex-1 rounded bg-whitesmoke-300 flex flex-col pt-2.5 px-[15px] pb-5 items-start justify-start gap-[5px]">
                      <div className="relative w-[422px] h-8 shrink-0">
                        <b className="absolute top-[4.71px] left-[0px] leading-[20px]">{`Input example #1 `}</b>
                        <div className="absolute top-[calc(50%_-_16px)] left-[112.69px] rounded-2xl w-8 h-8 overflow-hidden text-center text-lg font-material-icons">
                          <div className="absolute top-[7px] left-[7px] leading-[24px] flex items-center justify-center w-[18.2px] h-[18px]">
                            content_copy
                          </div>
                        </div>
                      </div>
                      <div className="overflow-hidden flex flex-row py-0 pr-[405px] pl-0 items-start justify-start font-roboto-mono">
                        <div className="relative leading-[20px]">23</div>
                      </div>
                    </div>
                    <div className="flex-1 rounded bg-whitesmoke-300 flex flex-col pt-2.5 px-[15px] pb-5 items-start justify-start gap-[5px]">
                      <div className="relative w-[422px] h-8 shrink-0">
                        <b className="absolute top-[4.71px] left-[0px] leading-[20px]">{`Output example #1 `}</b>
                        <div className="absolute top-[calc(50%_-_16px)] left-[123px] rounded-2xl w-8 h-8 overflow-hidden text-center text-lg font-material-icons">
                          <div className="absolute top-[7px] left-[7px] leading-[24px] flex items-center justify-center w-[18.2px] h-[18px]">
                            content_copy
                          </div>
                        </div>
                      </div>
                      <div className="overflow-hidden flex flex-row py-0 pr-[396px] pl-0 items-start justify-start font-roboto-mono">
                        <div className="relative leading-[20px]">2 3</div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
              <div className="absolute top-[753.18px] left-[0px] flex flex-row pt-[31px] px-[25px] pb-[30px] items-start justify-start text-xl font-material-icons border-t-[1px] border-solid border-gainsboro-200">
                <div className="flex flex-row py-[5px] pr-[719.6099853515625px] pl-[5px] items-start justify-start gap-[10px]">
                  <div className="overflow-hidden flex flex-row items-start justify-start">
                    <div className="relative leading-[20px]"></div>
                  </div>
                  <div className="overflow-hidden flex flex-row py-0 pr-[4.3899993896484375px] pl-0 items-start justify-start text-sm font-heading-2">
                    <i className="relative leading-[20px]">
                      Show problem classification
                    </i>
                  </div>
                </div>
              </div>
              <div className="absolute top-[844.18px] left-[0px] flex flex-row pt-4 pb-[15px] pr-[14.999969482421875px] pl-[881.780029296875px] items-start justify-start text-center text-sm border-t-[1px] border-solid border-gainsboro-200">
                <div className="rounded-sm overflow-hidden flex flex-row py-0 pr-2 pl-[7px] items-center justify-start gap-[0.22px]">
                  <a
                    className="relative leading-[36px] uppercase font-medium text-[inherit] [text-decoration:none]"
                    href="https://www.eolymp.com/en/problems/2"
                    target="_blank"
                  >
                    Digits
                  </a>
                  <div className="relative text-5xl leading-[24px] font-material-icons">
                    
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
        <div className="absolute top-[1210px] left-[470px] rounded bg-light shadow-[0px_2px_2px_rgba(0,_0,_0,_0.14),_0px_3px_1px_-2px_rgba(0,_0,_0,_0.2),_0px_1px_5px_rgba(0,_0,_0,_0.12)] w-[980px] h-60 overflow-hidden text-xl text-gray-400">
          <div className="absolute top-[0px] left-[0px] w-[980px] h-60">
            <div className="absolute top-[23px] left-[15px] leading-[40px] flex items-center w-[115.37px] h-6">
              My Solutions
            </div>
            <div className="absolute top-[65px] left-[15px] w-[950px] h-40 text-center text-lg text-blur">
              <div className="absolute top-[31px] left-[261.72px] leading-[24px] flex items-center justify-center w-[426.96px] h-[21px]">
                You have not submitted any solutions for the problem
              </div>
              <div className="absolute top-[calc(50%_+_14px)] left-[calc(50%_-_68.36px)] rounded-sm bg-secondary shadow-[0px_2px_2px_rgba(0,_0,_0,_0.14),_0px_3px_1px_-2px_rgba(0,_0,_0,_0.2),_0px_1px_5px_rgba(0,_0,_0,_0.12)] overflow-hidden flex flex-row py-0 pr-[7.6999969482421875px] pl-2 items-start justify-start text-sm text-light">
                <a
                  className="relative leading-[36px] uppercase font-medium text-[inherit] [text-decoration:none]"
                  href="https://www.eolymp.com/en/submissions/submit"
                  target="_blank"
                >
                  Submit solution
                </a>
              </div>
            </div>
          </div>
        </div>
        <div className="absolute w-[calc(100%_-_1px)] top-[0px] right-[0px] left-[1px] bg-primary box-border h-[123px] text-center text-3xl text-gray-500 border-b-[1px] border-solid border-linen">
          <div className="absolute w-[calc(100%_-_672px)] top-[calc(50%_-_20.5px)] right-[305px] left-[367px] h-[41px]">
            <div className="absolute top-[5px] left-[0px] w-[126.88px] h-[27px] overflow-hidden">
              <div className="absolute top-[0px] left-[calc(50%_-_63.44px)] w-[126.88px] h-[27px]" />
            </div>
            <div className="absolute top-[0px] left-[295px] leading-[42px]">
              LeaderBoards
            </div>
            <img
              className="absolute top-[calc(50%_-_11px)] left-[calc(50%_+_497.41px)] w-[22px] h-[22px] overflow-hidden"
              alt=""
              src="/svggamutmcjj5jsvg1.svg"
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
    </div>
  );
};

export default ChallengeQuestion;
