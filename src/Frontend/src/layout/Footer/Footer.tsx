const Footer = () => {
  const currentYear = new Date().getFullYear();

  return (
    <footer className="dark:bg-bar-gradient-dark bg-bar-gradient mt-auto py-4 text-center font-semibold text-white">
      <p>Activehub &copy; {currentYear}</p>
    </footer>
  );
};

export default Footer;
