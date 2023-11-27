import { useState } from "react";
import { BiList } from "../../assets/svg/BiList.svg";
import { BiXLg } from "../../assets/svg/BiXLg.svg";
import { PhSunFill } from "../../assets/svg/PhSun.svg";
import { PhMoonFill } from "../../assets/svg/PhMoon.svg";
import { useDarkMode } from "../../hooks/useDarkMode";

const Navbar = () => {
  const [navDrawer, toggleNavDrawer] = useState<boolean>(false);

  const [darkMode, toggleDarkMode] = useDarkMode();

  return (
    <nav className="dark:bg-bar-gradient-dark bg-bar-gradient fixed top-0 z-50 flex max-h-14 w-full items-center justify-between px-8 py-2 text-white md:px-24">
      <a href="/" className="flex items-center text-2xl">
        <img src="/assets/logo.png" alt="logo" className="mr-2 h-12" />
        <span>Activehub</span>
      </a>
      <div className="flex items-center">
        <div
          className={
            "fixed left-0 top-0 -z-10 h-screen w-full translate-x-[-100%] bg-black/75 backdrop-blur-sm transition duration-300 ease-linear md:static md:h-fit md:w-fit md:translate-x-0 md:bg-transparent md:backdrop-blur-none" +
            " " +
            (navDrawer && "translate-x-[0%]")
          }
        >
          <ul className="m-8 flex h-full flex-col items-center justify-center gap-16 md:flex-row md:items-center md:gap-4 [&>li>a:hover]:text-cyan-400 [&>li]:text-2xl [&>li]:font-semibold md:[&>li]:text-base">
            <li>
              <a href="#">Atividades</a>
            </li>
            <li className="w-fit rounded bg-green-700 p-2 hover:bg-green-600">
              <button>Criar atividade</button>
            </li>
          </ul>
        </div>
        <div className="flex gap-2">
          <button
            className="h-8 w-8 rounded border-[1px] border-slate-200 border-opacity-20 p-1"
            onClick={() => toggleDarkMode()}
          >
            {darkMode ? <PhSunFill /> : <PhMoonFill />}
          </button>
          <button
            className="h-8 w-8 rounded border-[1px] border-slate-200 border-opacity-20 p-1 md:hidden"
            onClick={() => toggleNavDrawer((state) => !state)}
          >
            {navDrawer ? (
              <BiXLg className="stroke-white" />
            ) : (
              <BiList className="stroke-white" />
            )}
          </button>
        </div>
      </div>
    </nav>
  );
};

export default Navbar;
