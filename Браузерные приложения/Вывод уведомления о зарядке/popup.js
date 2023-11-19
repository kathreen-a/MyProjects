document.addEventListener('DOMContentLoaded', () => {
  const basic = document.getElementById('basic');
  const progressNotif = document.getElementById('progress');
  const list = document.getElementById('list');


  progressNotif.addEventListener('click', () => {
    let options = {
      type: 'progress',
      title: 'You need to do exersises!',
      message: 'Get up and do neck and shoulder exercises',
      iconUrl: 'icon_128.png',
      progress: 99
    };
    chrome.notifications.create(options);
  });

  setInterval(() => {
    let options = {
      type: 'basic',
      title: 'Reminder',
      message: 'Time to do exercises!',
      iconUrl: 'icon_128.png'
    };
    chrome.notifications.create(options);
  }, 2 * 60 * 60 * 1000); // 2 часа в миллисекундах
  
});
