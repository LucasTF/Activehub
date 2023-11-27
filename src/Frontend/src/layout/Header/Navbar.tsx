import { useState } from "react";
import { BiList } from "../../assets/svg/BiList.svg";
import { BiXLg } from "../../assets/svg/BiXLg.svg";

const Navbar = () => {
  const [navDrawer, toggleNavDrawer] = useState<Boolean>(false);

  return (
    <nav className="fixed top-0 z-50 flex max-h-14 w-full items-center justify-between bg-gradient-to-r from-sky-800 to-blue-600 px-8 py-2 text-white md:px-48">
      <a href="/" className="flex items-center text-2xl">
        <img src="/assets/logo.png" alt="logo" className="mr-2 h-12" />
        <span>Activehub</span>
      </a>
      <button onClick={() => toggleNavDrawer((state) => !state)}>
        {navDrawer ? (
          <BiXLg className="h-10 w-10 rounded border-[1px] border-slate-200 border-opacity-20 stroke-slate-200 p-1 md:hidden" />
        ) : (
          <BiList className="h-10 w-10 rounded border-[1px] border-slate-200 border-opacity-20 stroke-slate-200 p-1 md:hidden" />
        )}
      </button>
      <div
        className={
          "fixed left-0 top-0 h-screen w-2/3 translate-x-[-100%] bg-gradient-to-r from-sky-800 to-blue-600 transition duration-300 ease-linear md:static md:h-fit md:w-fit md:translate-x-0 md:bg-none" +
          " " +
          (navDrawer && "translate-x-[0%]")
        }
      >
        <ul className="m-8 flex flex-col gap-4 md:flex-row md:items-center [&>li>a:hover]:text-cyan-400 [&>li]:font-semibold">
          <li>
            <a href="#">Atividades</a>
          </li>
          <li className="w-fit rounded bg-green-700 p-2 hover:bg-green-600">
            <button>Criar atividade</button>
          </li>
        </ul>
      </div>
    </nav>
  );
};

export default Navbar;
